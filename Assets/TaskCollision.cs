using UnityEngine;
using System.Collections;

public class TaskCollision : MonoBehaviour
{
    public bool OnTarget = false;
    public int objectiveOrder = 0;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.GetComponent<CarController>() != null)
        {
            Debug.Log("Collision happened");
            OnTarget = true;
        }
    }

    void OnTriggerExit(Collider col)
    {
        if(col.gameObject.GetComponent<CarController>() != null)
        {
            OnTarget = false;
        }
    }
}
