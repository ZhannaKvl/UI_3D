using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallTransform : MonoBehaviour
{
    public Vector3 scaleChange;
    [Range(0f, 5f)]
    public float speed;

    void Start()
    {
        speed = Random.Range(0f, 5f);
    }

    void Update()
    {
        transform.localScale += scaleChange;
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
