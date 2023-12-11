using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovableLeft : MonoBehaviour
{
    public float distance = 5.5f; // Distance that moves the object
    public bool horizontal = false; // Set to false for vertical movement
    public float speed = 3f;
    public float offset = 0f; // If you want to modify the position at the start

    private bool isLeftward = true; // If the movement is to the left
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
            if (isLeftward)
            {
                if (transform.position.z > startPos.z - distance) // Reverse the condition here
                {
                    transform.position -= Vector3.forward * Time.deltaTime * speed; // Change to Vector3.forward for leftward movement
                }
                else
                    isLeftward = false;
            }
            else
            {
                if (transform.position.z < startPos.z)
                {
                    transform.position += Vector3.forward * Time.deltaTime * speed; // Change to Vector3.forward for leftward movement
                }
                else
                    isLeftward = true;
            }
        }
        else
        {
            // Your existing horizontal movement code
            if (isLeftward)
            {
                if (transform.position.x > startPos.x - distance) // Reverse the condition here
                {
                    transform.position -= Vector3.right * Time.deltaTime * speed; // Change to Vector3.left for leftward movement
                }
                else
                    isLeftward = false;
            }
            else
            {
                if (transform.position.x < startPos.x)
                {
                    transform.position += Vector3.right * Time.deltaTime * speed; // Change to Vector3.left for leftward movement
                }
                else
                    isLeftward = true;
            }
        }
    }
}
