using UnityEngine;

[ExecuteInEditMode]
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
