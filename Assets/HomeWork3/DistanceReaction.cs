using UnityEngine;

[ExecuteInEditMode]
public class DistanceReaction : MonoBehaviour
{
    /* Írj komponenst ami egy Gizmo vonalat rajzol, ami egy másik beállítható objektum-ig ér,
    de csak ha egy beállítható határérték alatt van a két objektum távolsága.
    Ha közel jár (90% vagy több) a távolság ehhez a határértékhez, a vonal színe legyen piros. */

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