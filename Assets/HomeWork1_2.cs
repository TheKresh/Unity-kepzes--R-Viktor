using UnityEngine;

public class HomeWork1_2 : MonoBehaviour
{
    /* Bemenetben megadott a "num" és az "exponent" egész számok. Írj programot, ami egy kimeneti változóba beírja a num szám az exponent-edik hatványát.
    Pl.num = 3, exponent = 2, végeredmény = 9 (32) */

    [SerializeField] int num;
    [SerializeField] int exponent;
    [SerializeField] int eredmeny;

    void OnValidate()
    {
        eredmeny = (num * exponent) + num; // kiirja a num hatvanyat, de nem tudom kiiratni vele zarojelben a num es az exponentben megadott szamokat
        /* eredmeny = (x + "(" + num + exponent + ")");  // ez igy mennyire szar elkepzeles? */
    }
}
