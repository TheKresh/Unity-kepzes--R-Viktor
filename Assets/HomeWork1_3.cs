using UnityEngine;

public class HomeWork1_3 : MonoBehaviour
{
    /* Írj programot, ami összeûz 3 bemeneten megadott string-et vesszõvel elválasztva! Az eredmény egy kimeneti string-be kerüljön be! */

    [SerializeField] string word1;
    [SerializeField] string word2;
    [SerializeField] string word3;
    [SerializeField] string merged;

    void OnValidate()
    {
        merged = word1 + "," + word2 + "," + word3;
    }
}
