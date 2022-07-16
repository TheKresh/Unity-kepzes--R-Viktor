using UnityEngine;

public class HomeWork3_2 : MonoBehaviour
{
    /* �rj komponenst, ami egy objektumot mindig 2 be�ll�that� egy�b A �s B objektum k�z�tti vonalon tart.
    Hogy a vonalon hol helyezkedik el azt egy bemeneti 0-1 �rt�ket felvehet� F sz�m hat�rozza meg:
    Ha F <= 0, akkor pont A-n�l kell legyen. 
    Ha F >= 1 pont B-n�l.
    Ha F == 0.5 pont k�z�pen.
    Ha F == 0.4 akkor majdnem k�z�pen, de valamivel k�zelebb A-hoz. */

    [SerializeField] Transform a;
    [SerializeField] Transform b;
    [SerializeField] float f;
    void Update()
    {
        Vector3 position = a.position - b.position;
        float x = Mathf.Clamp01(f);

        if (x <= 0)
            position = a.position;
        else if (x >= 1)
            position = b.position;
        else if (x == 0.5)
            position = (a.position + b.position) / 2;
        /* else if (f == 0.4)
            position = (a.position + b.position - v) / 2;       // v -vel valami baja van
            float v = 0.1f; */

        transform.position = position;
    }
}
