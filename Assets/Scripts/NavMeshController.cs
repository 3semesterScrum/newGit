using UnityEngine;
using System.Collections;

public class NavMeshController : MonoBehaviour
{
    [SerializeField]
    private GameObject[] targets;
    private NavMeshAgent agent;
    private int i = 0;
    Animator animator;

    float yRotation;
    float turn = 0;

    void Start()
    {

        agent = this.GetComponent<NavMeshAgent>();
        animator = this.GetComponent<Animator>();
        animator.SetBool("isWalking", true);
    }
    void FixedUpdate()
    {
        yRotation = transform.rotation.y;
    }
    void Update()
    {
        float dist = Vector3.Distance(targets[i].transform.position, transform.position);
        float rotationDiff = yRotation - transform.rotation.y;
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
