using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    float speed = 0.25f;
    float velocity = 0.25f;
    float smooth = 5.0f;
    float tiltAngle = 60.0f;

    void Update()
    {
        //Plane movements
        float moveHorizontally = Input.GetAxis("Horizontal");
        float moveVertically = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontally*velocity, moveVertically* -1*velocity, speed);
        transform.position += movement;
        

        // Smoothly tilts the plane towards a target rotation.
        float tiltAroundZ = Input.GetAxis("Horizontal") * tiltAngle;
        float tiltAroundX = Input.GetAxis("Vertical") * tiltAngle;

        // Rotate the plane by converting the angles into a quaternion.
        Quaternion target = Quaternion.Euler(tiltAroundX, 0, -tiltAroundZ);

        // Dampen towards the target rotation
        transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);

       

        
    }
}
