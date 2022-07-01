using UnityEngine;

public class HomeWork1_2 : MonoBehaviour
{
    /* Bemenetben megadott a "num" �s az "exponent" eg�sz sz�mok. �rj programot, ami egy kimeneti v�ltoz�ba be�rja a num sz�m az exponent-edik hatv�ny�t.
    Pl.num = 3, exponent = 2, v�geredm�ny = 9 (32) */

    [SerializeField] int num;
    [SerializeField] int exponent;
    [SerializeField] string eredmeny;
    int i;

    void OnValidate()
    {
        i = (int) Mathf.Pow(num, exponent);
        eredmeny = i + " " + "(" + num + exponent + ")";
    }
}
