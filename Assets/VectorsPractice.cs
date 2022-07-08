using UnityEngine;

public class VectorsPractice : MonoBehaviour
{
    [SerializeField] Vector2 myFirst2DVector;
    
    [SerializeField] Vector3 myFirst3DVector;
    [SerializeField] Vector3 mySecond3DVector;
    [SerializeField] float multiplier;

    [SerializeField] Vector3 summa;
    [SerializeField] Vector3 diference;
    [SerializeField] Vector3 product;
    [SerializeField] float lenght;
    [SerializeField] Vector2 normalised;

    void OnValidate()
    {
        // osszeadas
        summa = myFirst3DVector + mySecond3DVector;
        // kivonas
        diference = myFirst3DVector - mySecond3DVector;
        // szorzat
        product = myFirst3DVector * multiplier;

        // vektor hossza
        lenght = myFirst2DVector.magnitude;

        // normalizalt
        normalised = myFirst2DVector.normalized;

        // egyes komponensek elerese
        float x = myFirst3DVector.x;
        float y = myFirst3DVector.y;    // myFirst3DVector.y = 45; - be is allithatjuk egy adott vektor erteket
        float z = myFirst3DVector.z;

        // vektorok letrehozasa
        Vector3 vector3LocalVariable = new Vector3(1, 2, 3);
        Vector3 vector2LocalVariable = new Vector2(1, 2);
    }
}
