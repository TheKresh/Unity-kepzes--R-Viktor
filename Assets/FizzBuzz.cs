using UnityEngine;

public class FizzBuzz : MonoBehaviour
{
    /* Írj programot, ami a GameObeject létrejöttekor (Start metódus) kiírja a számokat 1-tõl N-ig. N számot egy bemeneti változóval adhatod meg.
   Ha a szám 3 többszöröse, a szám helyett: „fizz”-t írjon ki.
   Ha a szám 5 többszöröse, akkor „buzz”-t írjon ki.
   Ha a szám 3 és 5 többszöröse is, akkor „fizzbuzz”-t írjon ki.
   Minden egyéb esetben a számot magát írja ki. */

    [SerializeField] int n;

    void Start()
    {
        int i = 0;

        while (i < n)
        {
            i++;
            Debug.Log(i);

            if (i % 3 == 0)
            {
                Debug.Log("fizz");
            }
            if (i % 5 == 0)
            {
                Debug.Log("buzz");
            }
            if (i % 3 == 0 && i % 5 == 0)
            {
                Debug.Log("fizzbuzz");
            }         
        }
    }
}

// elszámol az N-ben megadott számig, de nem helyetesiti be a szám helyere a fizz-t vagy a buzz-t, hanem csak utána kiirja
