using System;
using UnityEngine;

public class ShipPawn : MonoBehaviour
{
    Rigidbody rb;
    public float forwardForce = 15f;
    public float backwardForce = 8f;
    public float pitchsSpeed = 20f;
    public float yawTorque = 10f;


    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Forward()
    {

        rb.AddRelativeForce(Vector3.forward * forwardForce);
    
    }

    public void Backward()
    {
        rb.AddRelativeForce(Vector3.back * backwardForce);

    }

    public void Rotation(float angle)
    {
        if (angle > 0)
        {
            transform.Rotate(Vector3.forward);
        }
        else if (angle < 0)
        {
            transform.Rotate(-Vector3.forward);
        }
    }

    public void Pitchs(float pitchsInput)
    {
        if (pitchsInput != 0)
        {
            float pitchAmount = pitchsInput * pitchsSpeed;
            Quaternion rotation = Quaternion.Euler(pitchAmount, 0f, 0f);

            rb.MoveRotation(rb.rotation * rotation);
        } 
    }

    public void Yaw(float yawIpunt)
    {
        Vector3 torque = transform.up * yawIpunt * yawTorque;
        rb.AddRelativeTorque(torque);
    }
}
