using UnityEngine;

public class NumToWords : MonoBehaviour
{
    /* �rj programot, ami �sszef�zi az els� N bemeneten megadott eg�sz sz�mot sz�vegg� vessz�vel elv�lasztva! */

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
