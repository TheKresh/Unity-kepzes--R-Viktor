using UnityEngine;

public class PrimeNumbers : MonoBehaviour
{
    /* �rjunk programot, ami ki�rja az els� 100 pr�msz�mot */

    int i = 1;

    void Start()
    {
        while (i <= 100)
        {
            i++;

            if (i % 1 == 0 && i % i == 0)
            {
                Debug.Log(i);
            }
        }
    }
}

// kiirja ami 1 -el es onmagaval oszthato, de azt is aminek ennel tobb osztoja is van