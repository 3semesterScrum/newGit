using UnityEngine;
using System.Collections;

public class TaskCollision : MonoBehaviour
{
    public bool OnTarget = false;
    public int objectiveOrder = 0;

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
