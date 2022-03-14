using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float camera_movement_speed;

    public Transform body;

    void Update()
    {
        float x_as = Input.GetAxis("Mouse Y");
        float y_as = Input.GetAxis("Mouse X");

        transform.Rotate(new Vector3(-x_as , 0, 0) * camera_movement_speed);
        body.Rotate(new Vector3(0, y_as, 0) * camera_movement_speed);
    }
}
