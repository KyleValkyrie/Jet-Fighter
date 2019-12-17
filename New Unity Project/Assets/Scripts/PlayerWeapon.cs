using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeapon : MonoBehaviour
{
    public AudioSource SFX;
    public Transform firepointLeft;
    public Transform firepointRight;
    public float fireRate = 5f;
    private float nextShot = 0f;
    public GameObject bullet;
    public float lifeTime = 3f;
    // Update is called once per frame
    void Update()
    {
       if (Input.GetButton("Fire1")&& Time.time >=nextShot)
       {
           nextShot = Time.time + 1f / fireRate;
           Shoot();
          
       }
    }
    void Shoot()
       
    {
        SFX.Play();
        var cloneLeft = Instantiate(bullet, firepointLeft.position, firepointLeft.rotation);
        Destroy(cloneLeft.gameObject, lifeTime);
        var cloneRight = Instantiate(bullet, firepointRight.position, firepointRight.rotation);
        Destroy(cloneRight.gameObject, lifeTime);
        SFX = GetComponent<AudioSource>();
  
    }
}
    
