using UnityEngine;

public class MoveCubeScript : MonoBehaviour
{
    public float speed = 5.0f;

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(1, 0.0f, 1);

        GetComponent<Rigidbody>().velocity=movement*speed;
    }
}

