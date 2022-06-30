using UnityEngine;

public class HomeWork1_1 : MonoBehaviour
{
    /* �rj programot, ami egy "num" bemenetben megadott eg�sz sz�mr�l, eld�nti hogy p�ros-e! 
     * A program egy string t�pus� kimenetbe �rja be, a P�ROS vagy a P�RATLAN sz�t. */

    [SerializeField] int num;
    [SerializeField] string P�rosVagyP�ratlan;

    void OnValidate()
    {
        /* Egy sorban if �s else
         * output = num % 2 == 0 ? "Even" : "Odd";  // V�geredm�ny = Logikai kifejez�s ? Ha igaz : Ha hamis */

        // Ugyan az t�bb sorban
        if (num % 2 == 0)
            P�rosVagyP�ratlan = "P�ROS";         // Ha egy �gon csak egy parancs van, mint itt, nem kell kapcsos z�r�jel
        else
            P�rosVagyP�ratlan = "P�RATLAN";
    }
}
