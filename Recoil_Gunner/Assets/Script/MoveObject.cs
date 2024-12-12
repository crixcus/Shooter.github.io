using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public float startSpeed = 0f; 
    public float acceleration = 2f; 
    public float startDelay = 0f; 

    private float currentSpeed; 

    void Start()
    {
        currentSpeed = startSpeed;
        StartCoroutine(MoveAfterDelay());
    }

    IEnumerator MoveAfterDelay()
    {
        yield return new WaitForSeconds(startDelay);

        while (true)
        {
            currentSpeed += acceleration * Time.deltaTime;

            transform.position += Vector3.right * currentSpeed * Time.deltaTime;

            yield return null;
        }
    }
}
