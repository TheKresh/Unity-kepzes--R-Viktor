using UnityEngine;

public class Serializables : MonoBehaviour
{
    [SerializeField] int intVar;
    [SerializeField] float floatVar;
    [SerializeField] string stringVar;
    [SerializeField] bool boolVar;

    [SerializeField] float summa;



    void Start()
    {
        Debug.Log(intVar + floatVar);   // szimplan osszeadja
    }

    private void OnValidate()
    {
        summa = intVar + floatVar;
    }
}
