using UnityEngine;
using System.Collections;

public class CubeMotor : MonoBehaviour
{

    public Vector3 MoveVector { set; get; }
    public VirtualJoystick joystick;
    private CarController car;

    private Rigidbody thisRigidbody;
    // Use this for initialization
    void Start()
    {
        car = GetComponent<CarController>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveVector = PoolInput();
        if (MoveVector.z == 0 && MoveVector.x == 0)
        {
            car.Move(MoveVector.x, MoveVector.z, 1f, 0f);
        }
        else
        {
            car.Move(MoveVector.x, MoveVector.z, MoveVector.z, 0f);
        }
    }

    private Vector3 PoolInput()
    {
        Vector3 dir = Vector3.zero;

        dir.x = joystick.Horizontal();
        dir.z = joystick.Vertical();
        if (dir.magnitude > 1)
        {
            dir.Normalize();
        }
        return dir;
    }
}
