using UnityEngine;
using System.Collections;

public class TBone : MonoBehaviour
{
    [SerializeField]
    private GameObject Car;
    [SerializeField]
    private GameObject playerVehicle;
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
        GameObject tBoner = Instantiate(Car);
        tBoner.transform.position = new Vector3(this.transform.position.x -6, this.transform.position.y + 1, this.transform.position.z + 7);
        Debug.Log("T-Boner spawned");
    }

    void OnTriggerEnter(Collider other)
    {
        minSpeed = playerVehicle.GetComponent<CarController>().CurrentSpeed;
        if (minSpeed > maxSpeed && canSpawn)
        {
            CreateTBoner();
            canSpawn = false;
        }
        Debug.Log("The minSpeed was: " + minSpeed);
    }
}
