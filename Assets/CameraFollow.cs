using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset =new Vector3(0f, 12f, -8f);

    private void LateUpdate()
    {
        if (target == null) return;

        transform.position = target.position + offset;
    }
}