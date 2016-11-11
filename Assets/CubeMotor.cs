using UnityEngine;
using System.Collections;

public class CubeMotor : MonoBehaviour {

    public float moveSpeed = 5.0f;
    public float drag = 0.1f;
    public float terminalRotationSpeed = 25.0f;
    public Vector3 MoveVector { set; get; }
    public VirtualJoystick joystick;
    private CarController car;

    private Rigidbody thisRigidbody;
	// Use this for initialization
	void Start () {
        car = GetComponent<CarController>();
        thisRigidbody = gameObject.AddComponent<Rigidbody>();
        //thisRigidbody.maxAngularVelocity = terminalRotationSpeed;
        //thisRigidbody.drag = drag;
	}
	
	// Update is called once per frame
	void Update () {
        MoveVector = PoolInput();
        if(car == null)
        {
            Move();
        }
        else
        {
            car.Move(MoveVector.x, MoveVector.z, MoveVector.z, 0f);
        }
	}

    private void Move()
    {
        thisRigidbody.AddForce(MoveVector * moveSpeed);
    }

    private Vector3 PoolInput()
    {
        Vector3 dir = Vector3.zero;

        dir.x = joystick.Horizontal();
        dir.z = joystick.Vertical();
        if (dir.magnitude>1)
        {
            dir.Normalize();
        }
        return dir;
    }
}
