using UnityEngine;

public class HomeWork3_2 : MonoBehaviour
{
    /* Írj komponenst, ami egy objektumot mindig 2 beállítható egyéb A és B objektum közötti vonalon tart.
    Hogy a vonalon hol helyezkedik el azt egy bemeneti 0-1 értéket felvehetõ F szám határozza meg:
    Ha F <= 0, akkor pont A-nál kell legyen. 
    Ha F >= 1 pont B-nél.
    Ha F == 0.5 pont középen.
    Ha F == 0.4 akkor majdnem középen, de valamivel közelebb A-hoz. */

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
