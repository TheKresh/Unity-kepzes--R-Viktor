using UnityEngine;

public class SwitchValues : MonoBehaviour
{
    [SerializeField] int num1;
    [SerializeField] int num2;

    void Start()
    {
        // megcserel
        int t = num1;
        num1 = num2;
        num2 = t; // megoldani segedvaltozo nelkul
    }
}
