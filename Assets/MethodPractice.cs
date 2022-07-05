using UnityEngine;

class MethodPractice : MonoBehaviour
{
    [SerializeField] float a;
    [SerializeField] float b;

    [SerializeField] float min;
    [SerializeField] float max;
    [SerializeField] float abs;
    [SerializeField] float power;

    void OnValidate() // void azt jelenti, hogy nincs tipusa
    {
        min = Mathf.Min(a, b);      // minimum
        max = Mathf.Max(a, b);      // maximum
        abs = Mathf.Abs(a);         // abszolut ertek
        power = Mathf.Pow(a, b);    // hatvanyozas
    }

    // sajat fuggvenyek
    float Minimum(float n1, float n2)  // n1 akarhanyszor felhasznalhato, mert csak egy segedvaltozo
    {
        float min;
        if (n1 < n2)
        {
            min = n1;
        }
        else
        {
            min = n2;
        }
        return min;
    }
    float MinimumV2(float n1, float n2)
    {
        if (n1 < n2)
        {
            return n1;
        }
        else
        {
            return n2;
        }
    }

    float Abssolute(float n1)
    {
        if (n1 < 0)
            return -n1; // vagy return n1 * -1
      
        return n1;
    }
}
