using UnityEngine;

public class ThreeStringListing : MonoBehaviour
{
    /* �rj programot, ami �ssze�z 3 bemeneten megadott string-et vessz�vel elv�lasztva! Az eredm�ny egy kimeneti string-be ker�lj�n be! */

    [SerializeField] string word1;
    [SerializeField] string word2;
    [SerializeField] string word3;
    [Space]
    [SerializeField] string listing;

    void OnValidate()
    {
        listing = word1 + "," + word2 + "," + word3;
    }
}
