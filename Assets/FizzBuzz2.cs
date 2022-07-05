using UnityEngine;

public class FizzBuzz2 : MonoBehaviour
{
    [SerializeField] int number;
    void Start()
    {
        for (int i = 1; i < number; i++)
        {
            bool devidableWith3 = i % 3 == 0;
            bool devidableWith5 = i % 5 == 0;
            bool devidableWith3And5 = devidableWith3 && devidableWith5;

            if (devidableWith3And5)
            {
                Debug.Log("fizzbuzz");
            }
            else if (devidableWith3)
            {
                Debug.Log("fizz");
            }
            else if (devidableWith5)
            {
                Debug.Log("buzz");
            }
            else
            {
                Debug.Log(i);
            }
        }
    }
}
