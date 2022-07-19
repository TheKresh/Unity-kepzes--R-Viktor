using UnityEngine;

[ExecuteInEditMode]
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
        if (a == null || b == null)
            return;

        transform.position = 
            Vector3.Lerp(a.position, b.position, f);
    }

    private void OnDrawGizmos()
    {
        float r = 0.25f;

        Gizmos.DrawWireSphere(a.position, r);
        Gizmos.DrawWireSphere(b.position, r);
        Gizmos.DrawLine(a.position, b.position);
    }
}
