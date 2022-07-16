using UnityEngine;

public class CircularMotion : MonoBehaviour
{
    /* Írj komponenst, ami egy pont körül körpályán mozgatja a GameObject-jét!
    Több megoldás is van, de mindegyikhez olyan megoldást kell használnotok, ami nem volt órán.
    Könnyû a megoldás. A feladat, hogy ti keressetek megoldást neten. */

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
// forrás YouTube: Unity3D - Circular Motion (https://www.youtube.com/watch?v=BGe5HDsyhkY&ab_channel=StuartSpence)