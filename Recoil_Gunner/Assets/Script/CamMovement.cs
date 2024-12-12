using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMovement : MonoBehaviour
{
    public Transform player; 
    public float smoothSpeed = 0.125f; 

    void Update()
    {

        Vector3 cameraPosition = transform.position;

        Vector3 targetPosition = new Vector3(player.position.x, cameraPosition.y, cameraPosition.z);

        cameraPosition.x = Mathf.Lerp(cameraPosition.x, targetPosition.x, smoothSpeed);

        transform.position = cameraPosition;
    }
}

