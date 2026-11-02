using UnityEngine;

public class Siesta : MonoBehaviour
{
    public float downForce;

    public Rigidbody2D siestaRB;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        siestaRB.AddForce(Vector3.right * 10f, ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        siestaRB.AddForce(-transform.up * downForce, ForceMode2D.Force);
        Debug.Log(siestaRB.linearVelocity);
    }
}
