using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Vehicle : MonoBehaviour
{

    public static string vehicle;
    [SerializeField]
    private GameObject patientbus;
    [SerializeField]
    private GameObject fejeblad;
    [SerializeField]
    private GameObject elTruck;
    [SerializeField]
    private GameObject sengeTransporter;
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

                GameObject carOne = Instantiate(patientbus);
                // var derp = GameObject.Find("BackgroundImage");
                //   car.gameObject.GetComponent<CubeMotor>().joystick=(VirtualJoystick)derp;
                carOne.name = "patient bus";
                carOne.tag = "vehicle";
                // Canvas  canvas = GameObject.Instantiate(Touch);
                var derp = GameObject.FindGameObjectWithTag("GameController");
                Debug.Log(derp.GetComponentInChildren<Image>());
                Debug.LogError(derp.GetComponentInChildren<Image>());
                carOne.gameObject.GetComponent<CubeMotor>().joystick = derp.GetComponentInChildren<Image>().GetComponent<VirtualJoystick>();


            }
            if (vehicle == "fejeblad")
            {
                GameObject carTwo = Instantiate(fejeblad);
                carTwo.name = "fejeblad";
                carTwo.tag = "vehicle";
                var derp = GameObject.FindGameObjectWithTag("GameController");
                Debug.LogError(derp.GetComponentInChildren<Image>());
                carTwo.gameObject.GetComponent<CubeMotor>().joystick = derp.GetComponentInChildren<Image>().GetComponent<VirtualJoystick>();
            }
            if (vehicle == "el truck")
            {
                GameObject carThree = Instantiate(elTruck);
                carThree.name = "el truck";
                carThree.tag = "vehicle";
                var derp = GameObject.FindGameObjectWithTag("GameController");
                Debug.LogError(derp.GetComponentInChildren<Image>());
                carThree.gameObject.GetComponent<CubeMotor>().joystick = derp.GetComponentInChildren<Image>().GetComponent<VirtualJoystick>();
            }
            if (vehicle == "Senge transport")
            {
                GameObject carFour = Instantiate(sengeTransporter);
                carFour.name = "senge transport";
                carFour.tag = "vehicle";
                var derp = GameObject.FindGameObjectWithTag("GameController");
                Debug.LogError(derp.GetComponentInChildren<Image>());
                carFour.gameObject.GetComponent<CubeMotor>().joystick = derp.GetComponentInChildren<Image>().GetComponent<VirtualJoystick>();
            }
            return true;
        }
        return false;
    }

}