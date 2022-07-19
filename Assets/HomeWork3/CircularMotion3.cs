using UnityEngine;

public class CircularMotion3 : MonoBehaviour
{
    [SerializeField] Vector3 axies;
    [SerializeField] float angularSpeed;
    [SerializeField] bool positiveDirection;

    // float angle;

    void Update()
    {
        float dir = positiveDirection ? 1 : -1;     // feltételes értékadás
        
        // angle += dir * angularSpeed * Time.deltaTime;

        // transform.rotation = Quaternion.AngleAxis(angle, axies);    // axies-el megadott vector körül forog a GameObject


        transform.Rotate(axies, angularSpeed * Time.deltaTime);     // ez azt a célt szolgálja, mint a kommentelt részek, csak ez egy régebbi megoldás, de ugyan úgy mûködik
    }
}
