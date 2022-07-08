using UnityEngine;

public class PositionFollower : MonoBehaviour
{
    /* �rjatok komponenst, ami mindig egy be�ll�that� pont (Vector3) fel� megy be�ll�that� fix sebess�ggel */


    [SerializeField] Vector3 positionToFollow;
    [SerializeField] float speed;

    void Update()
    {
        Vector3 velocity = (positionToFollow - transform.position).normalized;
        transform.position += speed * Time.deltaTime * velocity;
    }
}
