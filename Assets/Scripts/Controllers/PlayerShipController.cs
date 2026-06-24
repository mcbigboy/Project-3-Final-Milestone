using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShipController : MonoBehaviour
{
    // Assignment text appears to list W/D and A/S, but this uses standard WASD:
    // W/S thrust forward/backward, A/D yaw.


    [SerializeField] InputAction forward = new InputAction("Forward");
    [SerializeField] InputAction backward = new InputAction("Backward");
    [SerializeField] InputAction rotation = new InputAction("Rotatino");
    [SerializeField] InputAction pitchs = new InputAction("Pitchs");
    [SerializeField] InputAction yaw = new InputAction("Yaw");
   

    public ShipPawn pawn;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Forward();
        Backward();
        Rotation();
        Pitchs();
        Yaw();
    }

    private void Yaw()
    {
        float yawIpunt = yaw.ReadValue<float>();
        pawn.Yaw(yawIpunt);
    }
    private void Pitchs()
    {
        float pitchsInput = pitchs.ReadValue<float>();
        pawn.Pitchs(pitchsInput);
    }

    private void Rotation()
    {
        float rotationInput = rotation.ReadValue<float>();
        pawn.Rotation(rotationInput);
    }

    private void Backward()
    {
        if (backward.IsPressed())
        {
            pawn.Backward();
        }
    }

    private void Forward()
    {
        if (forward.IsPressed())
        {
            pawn.Forward();
        }
    }

    private void OnEnable()
    {
        forward.Enable();
        backward.Enable();
        rotation.Enable();
        pitchs.Enable();
    }
}
