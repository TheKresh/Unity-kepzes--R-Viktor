using UnityEngine;

public class NumToWords : MonoBehaviour
{
    /* �rj programot, ami �sszef�zi az els� N bemeneten megadott eg�sz sz�mot sz�vegg� vessz�vel elv�lasztva! */

    [SerializeField] int n;
    [Space]
    [SerializeField] string output;

    void OnValidate()
    {
        if (n == 0)
        {
            output = "zero";
        }
    }
}
