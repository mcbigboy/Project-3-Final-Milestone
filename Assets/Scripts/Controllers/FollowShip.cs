using UnityEngine;

public class FollowShip : MonoBehaviour

{

    public GameObject followShip;
    public Vector3 offset;
    public float lineSight;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Convert offset into world map coordinates 
        Vector3 lookPoint = followShip.transform.position + followShip.transform.TransformDirection(offset);

        // Do that difference thing 
        Vector3 shipToOffest = lookPoint - followShip.transform.position;

        // Make it all once and then multiply 
        shipToOffest.Normalize();
        shipToOffest *= lineSight;

        // Look way over Yonder 
        Vector3 lookPosition = followShip.transform.position + shipToOffest;

        // Look from here 
        transform.position = lookPosition;
        transform.LookAt(followShip.transform.position, Vector3.up);

    }

    public void MoveCamera(float moveCameraInput)
    {
        if (moveCameraInput > 0) 
        {
            lineSight++;
        }

        if(moveCameraInput < 0)
        {
            lineSight--;
        }

    }
}