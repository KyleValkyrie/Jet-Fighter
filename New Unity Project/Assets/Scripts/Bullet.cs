using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 200f;
    public int damage = 20;
    private Transform thisTransform;
    public Transform hitFeedback;

    void Start()
    {
       thisTransform = transform;
    }
    // Update is called once per frame
    void Update()
    {
        thisTransform.position += Time.deltaTime * speed * thisTransform.forward;
    }
    void OnCollisionEnter (Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            collision.gameObject.SendMessage("takeDamage", damage, SendMessageOptions.DontRequireReceiver);
            Destroy(gameObject);
        }
    }
     
}
