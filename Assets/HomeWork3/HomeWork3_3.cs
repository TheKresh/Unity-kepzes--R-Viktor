using UnityEngine;

public class HomeWork3_3 : MonoBehaviour
{
    /* Írj komponenst ami egy Gizmo vonalat rajzol, ami egy másik beállítható objektum-ig ér,
    de csak ha egy beállítható határérték alatt van a két objektum távolsága.
    Ha közel jár (90% vagy több) a távolság ehhez a határértékhez, a vonal színe legyen piros. */

    [SerializeField] Transform a;
    [SerializeField] Transform b;
    [SerializeField] Vector3 value;

    private void Update()
    {
        float distance = Vector3.Distance(a.position, b.position);
        float h = (a.position + b.position) < value * 2;

    }

    private void OnDrawGizmos()
    {
        if (h)
        {
            Gizmos.color = Color.green;
            Gizmos.DrawLine(a.position, b.position);
        }

        else if ()
        {
            Gizmos.color = Color.red;
            Gizmos.DrawLine(a.position, b.position);
        }
    }
}
