using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float maxHealth = 100f;
    public float currentHealth;
    public ParticleSystem explosionFX;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }
    public void takeDamage(float damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            explosionFX.Play();
            Die();
            
        }
    }
    void Die()
    {
        
        Destroy(gameObject);
      

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
