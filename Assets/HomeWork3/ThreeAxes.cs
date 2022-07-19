using UnityEngine;

public class ThreeAxes : MonoBehaviour
{
    /* Írj komponenst, ami mindhárom tengelyen egész számú pozíción tart egy GameObject-et!
Nem lehet pl: a pozíció (3.4, 2, 11.66). Ehelyett lenne: (3,2,12) */

    [ExecuteInEditMode] // ennek utána nézni hogy mit csinal
    void Update()
    {
        Vector3 position = transform.position;
        
        position.x = Mathf.Round(position.x);
        position.y = Mathf.Round(position.y);
        position.z = Mathf.Round(position.z);
        
        
        transform.position = position;
    }
}