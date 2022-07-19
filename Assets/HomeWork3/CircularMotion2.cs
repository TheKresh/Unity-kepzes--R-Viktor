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
            Mathf.Sin(angleInRad),0,Mathf.Cos(angleInRad));     // radianba kellett az érték
        pos *= radius;                                          // ezzel tudjuk megnövelni a radius méretét
        pos += center;                                          // ezzel tudjuk elmozdítani a centert

        transform.position = pos;
    }
}
