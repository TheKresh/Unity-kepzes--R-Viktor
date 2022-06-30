using UnityEngine;

public class HomeWork1_1 : MonoBehaviour
{
    /* Írj programot, ami egy "num" bemenetben megadott egész számról, eldönti hogy páros-e! 
     * A program egy string típusú kimenetbe írja be, a PÁROS vagy a PÁRATLAN szót. */

    [SerializeField] int num;
    [SerializeField] string PárosVagyPáratlan;

    void OnValidate()
    {
        /* Egy sorban if és else
         * output = num % 2 == 0 ? "Even" : "Odd";  // Végeredmény = Logikai kifejezés ? Ha igaz : Ha hamis */

        // Ugyan az több sorban
        if (num % 2 == 0)
            PárosVagyPáratlan = "PÁROS";         // Ha egy ágon csak egy parancs van, mint itt, nem kell kapcsos zárójel
        else
            PárosVagyPáratlan = "PÁRATLAN";
    }
}
