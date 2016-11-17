using UnityEngine;
using System.Collections;

public class TBone : MonoBehaviour
{
    [SerializeField]
    private GameObject Car;
    float minSpeed;
    float maxSpeed = 1;
    float actualSpeed;
    bool canSpawn = true;
    float ready = 0;
	void Update ()
    {
        if (!canSpawn)
        {
            ready += Time.deltaTime;
            if (ready > 4)
            {
                canSpawn = true;
                ready = 0;
            }
        }
	}

    public void CreateTBoner()
    {
        
        GameObject tBoner = (GameObject)Instantiate(Car, this.transform.position - (transform.forward)+ (transform.right*12), transform.rotation);
        Transform change = tBoner.transform;
        change.Rotate(0f, 90f, 0f);
        Debug.Log("T-Boner spawned");
    }

    void OnTriggerEnter(Collider other)
    {
        minSpeed = other.gameObject.GetComponent<CarController>().CurrentSpeed;
        if (minSpeed > maxSpeed && canSpawn)
        {
            CreateTBoner();
            canSpawn = false;
        }
        Debug.Log("The minSpeed was: " + minSpeed);
    }
}
