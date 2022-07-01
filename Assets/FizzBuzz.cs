using UnityEngine;

public class FizzBuzz : MonoBehaviour
{
    /* �rj programot, ami a GameObeject l�trej�ttekor (Start met�dus) ki�rja a sz�mokat 1-t�l N-ig. N sz�mot egy bemeneti v�ltoz�val adhatod meg.
   Ha a sz�m 3 t�bbsz�r�se, a sz�m helyett: �fizz�-t �rjon ki.
   Ha a sz�m 5 t�bbsz�r�se, akkor �buzz�-t �rjon ki.
   Ha a sz�m 3 �s 5 t�bbsz�r�se is, akkor �fizzbuzz�-t �rjon ki.
   Minden egy�b esetben a sz�mot mag�t �rja ki. */

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

// elsz�mol az N-ben megadott sz�mig, de nem helyetesiti be a sz�m helyere a fizz-t vagy a buzz-t, hanem csak ut�na kiirja
