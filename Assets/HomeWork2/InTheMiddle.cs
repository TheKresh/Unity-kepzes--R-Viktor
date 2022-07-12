using UnityEngine;

public class InTheMiddle : MonoBehaviour
{
    /* �rjatok komponenst, ami a gameObject-et 2 be�ll�that� poz�ci� k�zti k�z�ppontba teszi */

    [SerializeField] Vector3 p1;
    [SerializeField] Vector3 p2;

    void Update()
    {
        Vector3 average = (p1 + p2) / 2;       
        transform.position = average;
        // vagy egyszer�bben �gy --> transform.position = (p1 + p2) / 2f; - gyakorlatilag �tlagolta a p1 �s a p2 poz�ci� �sszeg�t
    }
}
