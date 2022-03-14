using UnityEngine;

public class Playercontroller : MonoBehaviour
{
    public float movement_speed;

    void Update()
    {
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");

        transform.Translate(new Vector3(horizontal, 0, vertical) * movement_speed * Time.deltaTime, Space.Self);
    }
}
