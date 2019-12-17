using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public float speed = 15f;
    public float approachDistance =300f;
    public float maintainDistance = 100f;
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, player.position) < approachDistance)
        {
            Vector3 targetDirection = player.position - transform.position;
            Vector3 newDirection = Vector3.RotateTowards(transform.forward, targetDirection, speed * Time.deltaTime, 0.0f);
            transform.position = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
            transform.rotation = Quaternion.LookRotation(newDirection);
        }
        else if (Vector3.Distance(transform.position, player.position) > maintainDistance && Vector3.Distance(transform.position, player.position) < approachDistance)
        {
            Vector3 targetDirection = player.position - transform.position;
            Vector3 newDirection = Vector3.RotateTowards(transform.forward, targetDirection, -speed * Time.deltaTime, 0.0f);
            transform.position = this.transform.position;
            transform.rotation = Quaternion.LookRotation(newDirection);
        }
        else if (Vector3.Distance(transform.position, player.position) > maintainDistance)
        {
            Vector3 targetDirection = player.position + transform.position;
            Vector3 newDirection = Vector3.RotateTowards(transform.forward, targetDirection, -speed * Time.deltaTime, 0.0f);
            transform.position = Vector3.MoveTowards(transform.position, player.position, -speed * Time.deltaTime);
            transform.rotation = Quaternion.LookRotation(newDirection);
        }
    }
}
