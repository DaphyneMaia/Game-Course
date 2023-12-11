using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovableObsVert : MonoBehaviour
{
    public float distance = 5f; // Distance that moves the object
    public bool horizontal = false; // Set to false for vertical movement
    public float speed = 3f;
    public float offset = 0f; // If you want to modify the position at the start

    private bool isForward = true; // If the movement is out
    private Vector3 startPos;

    void Awake()
    {
        startPos = transform.position;
        if (!horizontal) // Change condition to check for vertical movement
            transform.position += Vector3.forward * offset; // Change to Vector3.forward for vertical movement
    }

    // Update is called once per frame
    void Update()
    {
        if (!horizontal) // Change condition to check for vertical movement
        {
            if (isForward)
            {
                if (transform.position.z < startPos.z + distance)
                {
                    transform.position += Vector3.forward * Time.deltaTime * speed;
                }
                else
                    isForward = false;
            }
            else
            {
                if (transform.position.z > startPos.z)
                {
                    transform.position -= Vector3.forward * Time.deltaTime * speed;
                }
                else
                    isForward = true;
            }
        }
        else
        {
            // Your existing horizontal movement code
            if (isForward)
            {
                if (transform.position.x < startPos.x + distance)
                {
                    transform.position += Vector3.right * Time.deltaTime * speed;
                }
                else
                    isForward = false;
            }
            else
            {
                if (transform.position.x > startPos.x)
                {
                    transform.position -= Vector3.right * Time.deltaTime * speed;
                }
                else
                    isForward = true;
            }
        }
    }
}
