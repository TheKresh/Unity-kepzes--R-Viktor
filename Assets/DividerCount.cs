using UnityEngine;

class DividerCount : MonoBehaviour
{
    [SerializeField] int num;
    [SerializeField] int countOfDividers;

    void OnValidate()
    {
        countOfDividers = 0;
        int i = 1;
        while (i < num)
        {
            bool isDividable = num % i == 0;
            if (isDividable)
                countOfDividers++;

            i++;
        }
    }
}
