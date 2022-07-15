using UnityEngine;

public class ThreeAxes : MonoBehaviour
{
    /* Írj komponenst, ami mindhárom tengelyen egész számú pozíción tart egy GameObject-et!
Nem lehet pl: a pozíció (3.4, 2, 11.66). Ehelyett lenne: (3,2,12) */

    float x;
    float y;
    float z;

    void Update()
    {
        Vector3 position = transform.position;

        position.x = Mathf.Round(x);
        x = position.x;
        position.y = Mathf.Round(y);
        y = position.y;
        position.z = Mathf.Round(z);
        z = position.z;

    }
}
