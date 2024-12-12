using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowBound : MonoBehaviour
{
    public Transform target; 

    void Update()
    {
        Vector3 currentPosition = transform.position;

        currentPosition.x = target.position.x;

        transform.position = currentPosition;
    }
}
