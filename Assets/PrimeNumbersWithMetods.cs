using UnityEngine;

public class PrimeNumbersWithMethods : MonoBehaviour
{
    [SerializeField] int number;
    [SerializeField] bool isPrime;

    void OnValidate()
    {
        int count = 0;
        int number = 2;
        while (count < 100)
        {
            bool isPrime = true;
            if (number < 2)
                isPrime = false;
            else
            {

                for (int i = 2; i < number; i++)
                {
                    bool d = number % i == 0;
                    if (d)
                    {
                        isPrime = false;
                    }
                }

                if (isPrime)
                {
                    Debug.Log(number);
                    count++;
                }
                number++;
            }
        }
    }

    bool IsPrime(float number)      // fuggveny elnevezest mindig nagybetuvel kezdjunk
    {
        bool isPrime = true;
        if (number < 2)
        {
            isPrime = false;
        }
        else
        {
            for (int i = 2; i < number; i++)
            {
                bool d = number % i == 0;
                if (d)
                {
                    isPrime = false;
                }
            }
        }
        return isPrime;
    }
}
