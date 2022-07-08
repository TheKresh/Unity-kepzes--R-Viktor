using UnityEngine;

public class NumToWords : MonoBehaviour
{
    /* Írj programot, ami összefûzi az elsõ N bemeneten megadott egész számot szöveggé vesszõvel elválasztva! */

    [SerializeField] int num;
    [SerializeField] string text;

    void Start()
    {
        text = "";
        for (int i = 1; i <= num; i++)
        {
            if (i < num)
            {
                text = text + i + ", ";
            }
            else
            {
                text = text + i;
            }
        }
    }
}
