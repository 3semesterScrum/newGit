using UnityEngine;
using System.Collections;

public class TaskCollision : MonoBehaviour
{
    public bool OnTarget = false;
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
        Debug.Log("Collision happened");
        if (col.gameObject.GetComponent<CarController>() != null)
        {
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
