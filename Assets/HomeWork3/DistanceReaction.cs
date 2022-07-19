using UnityEngine;

[ExecuteInEditMode]
public class DistanceReaction : MonoBehaviour
{
    /* �rj komponenst ami egy Gizmo vonalat rajzol, ami egy m�sik be�ll�that� objektum-ig �r,
    de csak ha egy be�ll�that� hat�r�rt�k alatt van a k�t objektum t�vols�ga.
    Ha k�zel j�r (90% vagy t�bb) a t�vols�g ehhez a hat�r�rt�khez, a vonal sz�ne legyen piros. */

    [SerializeField] Transform a;
    [SerializeField] Transform b;
    [SerializeField] Color colorA;
    [SerializeField] Color colorB;
    [SerializeField] float targetPosition;
    [SerializeField] float changeSpeed;

    float pos;

    void Start()
    {
        pos = targetPosition;
    }

    void Update()
    {
        pos = Mathf.MoveTowards(
            pos, 
            Mathf.Clamp01(targetPosition), 
            changeSpeed * Time.deltaTime);

        if (a == null || b == null)
            return;

        transform.position =
            Vector3.LerpUnclamped(a.position, b.position, pos);
    }

    private void OnDrawGizmos()
    {
        float r = 0.25f;

        Gizmos.DrawWireSphere(a.position, r);
        Gizmos.color = colorA;
        Gizmos.DrawWireSphere(b.position, r);
        Gizmos.color = colorB;

        Gizmos.color = Color.Lerp(colorA, colorB, targetPosition);
        Gizmos.DrawLine(a.position, b.position);
    }
} 