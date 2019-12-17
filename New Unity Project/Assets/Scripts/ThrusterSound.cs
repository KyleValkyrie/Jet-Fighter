using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrusterSound : MonoBehaviour
{
    public AudioSource ThrusterSFX;
    // Start is called before the first frame update
    void Start()
    {
        ThrusterSFX = GetComponent<AudioSource>();
        ThrusterSFX.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            ThrusterSFX.volume = 0.25f;
            ThrusterSFX.pitch = 3f;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            ThrusterSFX.volume = 0.1f;
            ThrusterSFX.pitch = 1f;
        }
    }
}
