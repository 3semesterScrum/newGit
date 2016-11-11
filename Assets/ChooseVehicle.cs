using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ChooseVehicle : MonoBehaviour {

   // public Vehicle vehicle;
    string derp;
	// Use this for initialization
	void Start () {
         derp = gameObject.name;
        Debug.Log(derp);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void LoadScene()
    {
        Vehicle.vehicle = derp;
      SceneManager.LoadScene("Hospital");
     //  vehicle.vehicle = derp;
    }
}
