using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject objectPrefab; 
    public int numberOfObjects = 5; 
    public float verticalSpacing = 2f; 
    public float staggerDelay = 3f; 

    void Start()
    {
        SpawnAllObjects();
    }

    void SpawnAllObjects()
    {
        Vector3 leftScreenPosition = Camera.main.ScreenToWorldPoint(new Vector3(2, Screen.height /1.1f, 10));

        for (int i = 0; i < numberOfObjects; i++)
        {
            Vector3 spawnPosition = new Vector3(leftScreenPosition.x + 1, leftScreenPosition.y - i * verticalSpacing, 0);                                        // z position set to 0 for 2D or leave as is for 3D

            GameObject spawnedObject = Instantiate(objectPrefab, spawnPosition, Quaternion.identity);

            spawnedObject.name = "MovingObject_" + i;

            MoveObject moveScript = spawnedObject.GetComponent<MoveObject>();
            if (moveScript != null)
            {
                moveScript.startDelay = i * staggerDelay;
            }
        }
    }
}
