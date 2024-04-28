using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraStop : MonoBehaviour
{
    public Camera mainCamera;

    public void OnClick()
    {
        mainCamera.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
    }
}
