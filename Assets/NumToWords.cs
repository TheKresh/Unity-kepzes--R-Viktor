using UnityEngine;

public class NumToWords : MonoBehaviour
{
    /* Írj programot, ami összefûzi az elsõ N bemeneten megadott egész számot szöveggé vesszõvel elválasztva! */

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
