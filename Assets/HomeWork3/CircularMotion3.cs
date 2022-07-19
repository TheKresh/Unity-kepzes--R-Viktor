using UnityEngine;

public class CircularMotion3 : MonoBehaviour
{
    [SerializeField] Vector3 axies;
    [SerializeField] float angularSpeed;
    [SerializeField] bool positiveDirection;

    // float angle;

    void Update()
    {
        float dir = positiveDirection ? 1 : -1;     // felt�teles �rt�kad�s
        
        // angle += dir * angularSpeed * Time.deltaTime;

        // transform.rotation = Quaternion.AngleAxis(angle, axies);    // axies-el megadott vector k�r�l forog a GameObject


        transform.Rotate(axies, angularSpeed * Time.deltaTime);     // ez azt a c�lt szolg�lja, mint a kommentelt r�szek, csak ez egy r�gebbi megold�s, de ugyan �gy m�k�dik
    }
}
