using UnityEngine;

public class BoolPractice : MonoBehaviour
{
    [SerializeField] bool hasRange;

    [SerializeField] int ageOfJohn;
    [SerializeField] int ageOfGreg;

    [SerializeField] bool isJohnOlderThanGreg;
    [SerializeField] bool isJhonAndGregTheSameAge;
    [SerializeField] bool isJhonAndGregNotTheSameAge;


    void OnValidate()
    {
        isJohnOlderThanGreg = ageOfJohn > ageOfGreg;
        isJhonAndGregTheSameAge = ageOfJohn == ageOfGreg;
        isJhonAndGregNotTheSameAge = ageOfJohn != ageOfGreg;

        float f1 = 3, f2 = 5;
        bool b1 = f1 <= f2; // Nagyobb vagy egyelo
        bool b2 = f1 >= f2; // Kisebb vagy egyelo


        float f = 3.45f;
        int i = 3;

        f = i;         // Implicit Casting
        i = (int) f;   // Explicit Casting

        bool a = true;
        bool b = false;
        bool c = false;
        int i1 = 3;
        int i2 = 6;
        int i3 = 10;
        string st = "AAA";

        bool aNegated = !a;         // true = ha egyik sem igaz
        bool aOrB = a || b;         // true = ha egy vagy az összes true ("|" - AltGr + W)
        bool aAndB = a && b;        // true = ha az összes true

        bool x = a || b && c;       // true OR false = true --> false AND false = false 
        bool y = (i1 > i2) || b;    // false
        bool z = (i2 <= i3) && st == "BBB";   // false
    }
}
