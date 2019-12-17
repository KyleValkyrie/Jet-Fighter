using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float maxPlayerHealth = 100f;
    public float currentPlayerHealth;
    public ParticleSystem explosionFX;
    // Start is called before the first frame update
    void Start()
    {
        currentPlayerHealth = maxPlayerHealth;
    }
    public void takeDamage(float damage)
    {
        currentPlayerHealth -= damage;
        if (currentPlayerHealth <= 0)
        {
            explosionFX.Play();
            Die();
            
        }
    }
    void Die()
    {
        
        Destroy(this);
        

    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
