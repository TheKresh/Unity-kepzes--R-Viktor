using UnityEngine;

public class Circle : MonoBehaviour
{
    [SerializeField] float radius;

    [SerializeField] float circumferance; // kerulet
    [SerializeField] float area; // terulet

    float pi = 3.14f;

    void OnValidate()
    {
        circumferance = 2 * radius * Mathf.PI;
        area = radius * radius * Mathf.PI;
    }
}
