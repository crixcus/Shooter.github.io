using UnityEngine;

public class CirclePlatform : MonoBehaviour
{
    public float moveSpeed = 3f; 
    public float moveDistance = 2f; 

    private Vector3 startingPosition;
    private float targetY;
    private bool movingUp = true;

    void Start()
    {
        startingPosition = transform.position;
        targetY = startingPosition.y + moveDistance; 
    }

    void Update()
    {
        if (movingUp)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(startingPosition.x, targetY, startingPosition.z), moveSpeed * Time.deltaTime);

            if (transform.position.y >= targetY)
            {
                movingUp = false;
            }
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(startingPosition.x, startingPosition.y, startingPosition.z), moveSpeed * Time.deltaTime);

            if (transform.position.y <= startingPosition.y)
            {
                movingUp = true;
            }
        }
    }
}
