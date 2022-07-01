using UnityEngine;

public class ControlStructuresPractice : MonoBehaviour
{
    [SerializeField] int a = 3;
    [SerializeField] int b = 5;

    [SerializeField] int n = 5;

    // Ctrl + KD gombkombinacio - elrendezi a kodot
    void Start()
    {
        // Selection (elagazas)
        if (a > b)
        {
            Debug.Log("A is Greater than B");
        }
        else
        {
            Debug.Log("A is NOT Greater than B");
        }

        // Loop (ciklus)

        int i = 1;

        while (i<= 10)
        {
            Debug.Log(i);
            i++;                        // egyesevel elszamol 10-ig
        }

        for (int j = 0; j < n; j++)
        {
            Debug.Log(i * 3);           // N-ben megadottszor megcsinálja, de ugyan az a végeredmény --> (33)
        }
    }
}
