using UnityEngine;

public class ThreeAxes : MonoBehaviour
{
    /* �rj komponenst, ami mindh�rom tengelyen eg�sz sz�m� poz�ci�n tart egy GameObject-et!
Nem lehet pl: a poz�ci� (3.4, 2, 11.66). Ehelyett lenne: (3,2,12) */

    [ExecuteInEditMode] // ennek ut�na n�zni hogy mit csinal
    void Update()
    {
        Vector3 position = transform.position;
        
        position.x = Mathf.Round(position.x);
        position.y = Mathf.Round(position.y);
        position.z = Mathf.Round(position.z);
        
        
        transform.position = position;
    }
}