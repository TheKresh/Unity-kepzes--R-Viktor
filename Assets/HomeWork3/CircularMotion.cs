using UnityEngine;

public class CircularMotion : MonoBehaviour
{
    /* �rj komponenst, ami egy pont k�r�l k�rp�ly�n mozgatja a GameObject-j�t!
    T�bb megold�s is van, de mindegyikhez olyan megold�st kell haszn�lnotok, ami nem volt �r�n.
    K�nny� a megold�s. A feladat, hogy ti keressetek megold�st neten. */

    float timeCounter = 0;

    [SerializeField] float speed;
    [SerializeField] float width;
    [SerializeField] float height;

    void Update()
    {
        timeCounter += Time.deltaTime * speed;

        float x = Mathf.Cos (timeCounter) * width;
        float y = Mathf.Sin (timeCounter) * height;
        float z = 0;

        transform.position = new Vector3(x, y, z);
    }
}
// forr�s YouTube: Unity3D - Circular Motion (https://www.youtube.com/watch?v=BGe5HDsyhkY&ab_channel=StuartSpence)