using UnityEngine;

class MethodPractice : MonoBehaviour
{
    [SerializeField] float a;
    [SerializeField] float b;

    [SerializeField] float min;
    [SerializeField] float max;
    [SerializeField] float abs;
    [SerializeField] float power;

    void OnValidate()
    {
        min = Mathf.Min(a, b);      // minimum
        max = Mathf.Max(a, b);      // maximum
        abs = Mathf.Abs(a);         // abszolut ertek
        power = Mathf.Pow(a, b);    // hatvanyozas
    }
}
