using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPOV : MonoBehaviour
{
    public Transform targetPlayer;
    public Vector3 distance= new Vector3(0f, 1.5f, -10f);
    public float positionDamping = 2f;  
    public float rotationDamping = 2f;
    private Transform thisTransform;
    void Start()
    {
        thisTransform = transform;
    }
    void LateUpdate()
    {
        if (targetPlayer == null)
        {
            return;
        }
        Vector3 wantedPosition = targetPlayer.position + (targetPlayer.rotation * distance);

        Vector3 currentPosition = Vector3.Lerp(thisTransform.position, wantedPosition, positionDamping * Time.deltaTime);

        thisTransform.position = currentPosition;

        Quaternion wantedRotation = Quaternion.LookRotation(targetPlayer.position - thisTransform.position, targetPlayer.up);
        thisTransform.rotation = wantedRotation;
     }
}
