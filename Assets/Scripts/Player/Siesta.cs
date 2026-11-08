using UnityEngine;

public class Siesta : MonoBehaviour
{
    public float downForce;
    public WheelJoint2D frontWheel;
    public WheelJoint2D backWheel;

    JointMotor2D wheel1;
    JointMotor2D wheel2;

    public Rigidbody2D siestaRB;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        //siestaRB.AddForce(Vector3.right * 10f, ForceMode2D.Impulse);
        wheel1 = frontWheel.motor;
        wheel2 = backWheel.motor;
    }

    // Update is called once per frame
    void Update()
    {
        //siestaRB.AddForce(-transform.up * downForce, ForceMode2D.Force);
        wheel1.motorSpeed = -9000;
        wheel2.motorSpeed = -9000;

        frontWheel.motor = wheel1;
        backWheel.motor = wheel2;

        Debug.Log(siestaRB.linearVelocity);
    }
}
