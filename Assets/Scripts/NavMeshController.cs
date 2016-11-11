using UnityEngine;
using System.Collections;

public class NavMeshController : MonoBehaviour
{
    [SerializeField]
    private GameObject[] targets;
    private NavMeshAgent agent;
    private int i = 0;
    

    void Start()
    {

        agent = this.GetComponent<NavMeshAgent>();

    }

    void Update()
    {

        float dist = Vector3.Distance(targets[i].transform.position, transform.position);
        agent.SetDestination(targets[i].transform.position);
        if (dist < 3)
        {
            i++;
        }
        if (i == targets.Length)
        {
            i = 0;
        }

    }
}
