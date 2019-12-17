using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{

    public ParticleSystem LeftThruster;
    public ParticleSystem RightThruster;
    public ParticleSystem MiddleThruster;
    public float speed = 20f;
    private float speedUpperLimit = 100f;
    private float speedLowerLimit = 10f;
    public float velocity = 10f;
    float roll;
    float pitch;

    void thrusterAnimationOn()
    {
        LeftThruster.startLifetime = 1f;
        LeftThruster.startSize = 1.5f;
        RightThruster.startLifetime=1f;
        RightThruster.startSize = 1.5f;
        MiddleThruster.startLifetime=2f;
        MiddleThruster.startSize = 1.5f;
    }
    void thrusterAnimationOff()
    {
        LeftThruster.startLifetime = 0.5f;
        LeftThruster.startSize = 0.5f;
        RightThruster.startLifetime=0.5f;
        RightThruster.startSize = 0.5f;
        MiddleThruster.startLifetime=1f;
        MiddleThruster.startSize = 0.5f;
    }
    
    void movement()
    //Make the plane keep flying endlessly forward
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.Space))
        {
            while (speed < speedUpperLimit)
            {
                speed = speed + velocity;
                thrusterAnimationOn();
            }
        }
         if (Input.GetKeyUp(KeyCode.Space))
         {
            while (speed > speedLowerLimit)
            {
                speed = speed/ 20f ;
                thrusterAnimationOff();
            }
             
         }
      
    }
    void Update()
    {
       
        movement();
        
        
        //Plane rotation
        roll = Input.GetAxisRaw("Horizontal");
        pitch = Input.GetAxisRaw("Vertical");

        transform.Rotate(Vector3.back * roll * 100f * Time.deltaTime, Space.Self);
        transform.Rotate(Vector3.right * pitch * 100f * Time.deltaTime, Space.Self);

       
     }
}
