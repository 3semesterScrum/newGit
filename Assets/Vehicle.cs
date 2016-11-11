using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Vehicle : MonoBehaviour
{

    public static string vehicle;
    public GameObject Car;
    public Canvas Touch;
    // Use this for initialization


    void Start()
    {


        DontDestroyOnLoad(this);
    }


    // Update is called once per frame
    void Update()
    {
        if (CreateVehicle() == false)
        {
            CreateVehicle();
        }

    }
    private bool CreateVehicle()
    {
        if (!GameObject.FindGameObjectWithTag("vehicle"))
        {

            if (vehicle == "patient bus")
            {

                // farve.material.color = Color.blue;
                //  GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);

                GameObject car = Instantiate(Car);
                // var derp = GameObject.Find("BackgroundImage");
                //   car.gameObject.GetComponent<CubeMotor>().joystick=(VirtualJoystick)derp;
                car.name = "patient bus";
                car.tag = "vehicle";
                // Canvas  canvas = GameObject.Instantiate(Touch);
                var derp = GameObject.FindGameObjectWithTag("GameController");
                Debug.LogError(derp.GetComponentInChildren<Image>());
                car.gameObject.GetComponent<CubeMotor>().joystick = derp.GetComponentInChildren<Image>().GetComponent<VirtualJoystick>();


            }
            if (vehicle == "fejeblad")
            {
                // farve.material.color = Color.green;
                GameObject capsule = GameObject.CreatePrimitive(PrimitiveType.Capsule);
                capsule.name = "fejeblad";
                capsule.tag = "vehicle";
            }
            if (vehicle == "el truck")
            {
                GameObject cylinder = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
                cylinder.name = "el truck";
                cylinder.tag = "vehicle";
                //  farve.material.color = Color.red;
            }
            if (vehicle == "Senge transport")
            {
                GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                sphere.name = "senge transport";
                sphere.tag = "vehicle";
                // farve.material.color = Color.yellow;
            }
            return true;
        }
        return false;
    }

}