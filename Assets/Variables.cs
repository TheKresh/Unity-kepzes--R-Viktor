
using UnityEngine;

public class Variables : MonoBehaviour
{
    // Start is called before the first frame update
    // komment, amit a gép figyelmen kívül hagy
    void Start()
    {
       // Debug.Log("drt"); /* komment, amit a gép figyelmen kívül hagy */ Debug.Log("drt"); //

        /*
        Multiple
        Line
        Comment
        */

        int myFirstVariable; // Declaration (deklaráció)
        myFirstVariable = 5; // Definition (definíció)

        Debug.Log(myFirstVariable);
        myFirstVariable = 7;  // Set new value
        Debug.Log(myFirstVariable);

        // int a, b, c;  // Declaration of multiple variables

        int secondVariable = 3;  // Declaration & Definition in 1 line
        Debug.Log(secondVariable);

        // Declaration & Definition of multiple variables
        int x = 3, y = 7, z = -1;
        y = 22;

        int summa = x + y + z;
        Debug.Log(summa);

        int product = x * y * z * 2;
        Debug.Log(product);

        int dif = x - y;
        Debug.Log(dif);

        int rate = x / y;
        Debug.Log(rate);

        int negate = -x;
        Debug.Log(negate);

        int modulo = x % y; // osztas maradeka
        Debug.Log(modulo);
    }

}
