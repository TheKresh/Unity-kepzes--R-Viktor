using UnityEngine;

public class PositionFollower : MonoBehaviour
{
    /* Írjatok komponenst, ami mindig egy beállítható pont (Vector3) felé megy beállítható fix sebességgel */


    [SerializeField] Vector3 positionToFollow;
    [SerializeField] float speed;

    void Update()
    {
        Vector3 velocity = (positionToFollow - transform.position).normalized;
        transform.position += speed * Time.deltaTime * velocity;
    }
}
