using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidGenerator : MonoBehaviour
{
    public Transform asteroidModel1;
    public Transform asteroidModel2;
    public int fieldRadius = 10000;

    public int asteroidCount = 10;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i <= asteroidCount; i++)
        {
            Transform template1 = Instantiate(asteroidModel1, Random.insideUnitSphere * fieldRadius, Random.rotation);
            template1.localScale = template1.localScale * Random.Range(1f, 1f);
            Transform template2 = Instantiate(asteroidModel2, Random.insideUnitSphere * fieldRadius, Random.rotation);
            template2.localScale = template2.localScale * Random.Range(1f, 15f);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
