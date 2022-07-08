using UnityEngine;

public class ThreeStringListing : MonoBehaviour
{
    /* Írj programot, ami összeûz 3 bemeneten megadott string-et vesszõvel elválasztva! Az eredmény egy kimeneti string-be kerüljön be! */

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
