using UnityEngine;

public class LinearMover : MonoBehaviour
{
    [SerializeField] KeyCode upKey;
    [SerializeField] KeyCode downKey;
    [SerializeField] KeyCode rightKey;
    [SerializeField] KeyCode leftKey;
    [SerializeField] float speed;
    
    // Update csak akkor fut le ha play modeban vagyunk
    void Update()
    {
        bool up = Input.GetKey(upKey);
        bool down = Input.GetKey(downKey);
        bool right = Input.GetKey(rightKey);
        bool left = Input.GetKey(leftKey);

        float x = ToAxis(right, left);
        float y = ToAxis(up, down);
        
        Vector3 velocity = new Vector3(x, y, 0); // "izometrikus nezetben" - Vector3 velocity = new Vector3(x, 0, z);

        transform.position += velocity.normalized * speed * Time.deltaTime;     // velocity - sebesség
    }

    float ToAxis(bool positive, bool negative) 
    {
        float value;
        if (positive)
        {
            value = 1;
        }
        else if (negative)
        {
            value = -1;
        }
        else
        {
            value = 0;
        }
        return value;
    }

}
