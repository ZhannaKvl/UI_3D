using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform target; 
    public Vector3 offset; 

    void LateUpdate()
    {
        if (target != null)
        {
            Vector3 desiredPosition = target.position + offset;
            transform.position = desiredPosition;
            transform.LookAt(target);
        }
    }
}
