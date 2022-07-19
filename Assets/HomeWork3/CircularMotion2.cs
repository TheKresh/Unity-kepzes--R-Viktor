using UnityEngine;

public class CircularMotion2 : MonoBehaviour
{
    [SerializeField] Vector3 center;
    [SerializeField] float radius;
    [SerializeField] float angularSpeed;

    float angle;

    void Update()
    {
        angle += angularSpeed * Time.deltaTime;

        float angleInRad = angle * Mathf.Deg2Rad;

        Vector3 pos = new Vector3(
            Mathf.Sin(angleInRad),0,Mathf.Cos(angleInRad));     // radianba kellett az �rt�k
        pos *= radius;                                          // ezzel tudjuk megn�velni a radius m�ret�t
        pos += center;                                          // ezzel tudjuk elmozd�tani a centert

        transform.position = pos;
    }
}
