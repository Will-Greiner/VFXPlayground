using UnityEngine;

public class SimpleMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    void Start() { Cursor.visible = false; }
    void Update()
    {
        // 1. Detect WASD and Arrow key input
        float moveX = Input.GetAxis("Horizontal"); // A/D or Left/Right arrows
        float moveZ = Input.GetAxis("Vertical");   // W/S or Up/Down arrows

        // 2. Create a movement direction vector (X = Left/Right, Z = Forward/Backward)
        Vector3 movement = new Vector3(moveX, 0f, moveZ);

        // 3. Move the object smoothly over time
        transform.Translate(movement * moveSpeed * Time.deltaTime, Space.World);
    }
}
