using UnityEngine;
using System.Collections;

public class NavMeshController : MonoBehaviour
{
    [SerializeField]
    private GameObject[] targets;
    private GameObject avoid;
    private NavMeshAgent agent;
    private int i = 0;
    Animator animator;
    float yRotation;
    float turn = 0;
    float rotateNPC = 0;
    bool vehicleFound = false;
    bool hasturned = false;

    void Start()
    {
        agent = this.GetComponent<NavMeshAgent>();
        animator = this.GetComponent<Animator>();
        animator.SetBool("isWalking", true);
        avoid = GameObject.FindGameObjectWithTag("vehicle");
    }
    void FixedUpdate()
    {
        yRotation = transform.rotation.y;
    }
    void Update()
    {
        float avoidDist = Vector3.Distance(avoid.transform.position, transform.position);
        Debug.Log("AvoidDist: " + avoidDist);
        AvoidVehicle(avoidDist);
        if (avoidDist > 8)
        {
            float dist = Vector3.Distance(targets[i].transform.position, transform.position);
            MoveNPC(dist);
        }
        float rotationDiff = yRotation - transform.rotation.y;
        AnimateNPC(rotationDiff);

    }
    public void AvoidVehicle(float avoidDist)
    {
        if (avoidDist < 8)
        {
            rotateNPC = 1;
            transform.Rotate(new Vector3(0, rotateNPC));
            if (transform.rotation.y > 45)
            {
                rotateNPC = -1;
            }
            transform.Translate(new Vector3(0, 0, 2) * Time.deltaTime);
        }
    }
    public void AnimateNPC(float rotationDiff)
    {
        if (rotationDiff > 0.005f || rotationDiff < -0.005f)
        {
            if (yRotation < transform.rotation.y)
            {
                //Turn Right
                turn += 0.1f;
                if (turn >= 1)
                {
                    turn = 1;
                }
                animator.SetFloat("BlendNPC", turn);
            }
            else if (yRotation > transform.rotation.y)
            {
                //Turn left
                turn -= 0.1f;
                if (turn <= -1)
                {
                    turn = -1;
                }
                animator.SetFloat("BlendNPC", turn);
            }
        }
        else
        {
            if (turn > 0)
            {
                turn -= 0.1f;
            }
            else if (turn < 0)
            {
                turn += 0.1f;
            }
            else
            {
                turn = 0;
            }
        }
        animator.SetFloat("BlendNPC", turn);

    }
    public void MoveNPC(float dist)
    {
        agent.SetDestination(targets[i].transform.position);

        if (dist < 2)
        {
            i++;
        }
        if (i == targets.Length)
        {
            i = 0;
        }
    }
}
