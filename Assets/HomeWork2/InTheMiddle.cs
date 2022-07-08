using UnityEngine;

public class InTheMiddle : MonoBehaviour
{
    /* Írjatok komponenst, ami a gameObject-et 2 beállítható pozíció közti középpontba teszi */

    [SerializeField] Vector3 p1;
    [SerializeField] Vector3 p2;

    void OnValidate()
    {
        transform.position = (p1 + p2) / 2f;    // gyakorlatilag átlagolta a p1 és a p2 pozíció összegét
    }
}
