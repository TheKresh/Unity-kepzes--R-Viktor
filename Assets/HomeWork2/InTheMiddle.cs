using UnityEngine;

public class InTheMiddle : MonoBehaviour
{
    /* Írjatok komponenst, ami a gameObject-et 2 beállítható pozíció közti középpontba teszi */

    [SerializeField] Vector3 p1;
    [SerializeField] Vector3 p2;

    void Update()
    {
        Vector3 average = (p1 + p2) / 2;       
        transform.position = average;
        // vagy egyszerûbben így --> transform.position = (p1 + p2) / 2f; - gyakorlatilag átlagolta a p1 és a p2 pozíció összegét
    }
}
