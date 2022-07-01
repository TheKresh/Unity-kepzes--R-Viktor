using UnityEngine;

public class HomeWork1_4 : MonoBehaviour
{
    /* Írj programot, ami összefûzi az elsõ N bemeneten megadott egész számot szöveggé vesszõvel elválasztva! */

    [SerializeField] int n;
    [SerializeField] string output;

    void OnValidate()
    {
        if (n == 0)
        {
            output = "zero";
        }
    }
}
