using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackPosition : MonoBehaviour
{
    public float speed = 1.0f; 
    public float maxX = 5.0f; 
    public float minX = -5.0f; 
    private bool moveRight = true; 

    void Update()
    {
        if (moveRight)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);

            if (transform.position.x >= maxX)
            {
                moveRight = false;
            }
        }
        else
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
            if (transform.position.x <= minX)
            {
                moveRight = true;
            }
        }
    }
}
