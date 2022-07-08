using UnityEngine;

public class MyMath : MonoBehaviour
{
    /* Nézzetek utána a következõ Mathf függvényeknek és írjátok meg a saját verziótokat belõlük:
    Max, Min, Clamp, Clamp01, Abs, Sign, Floor, Ceil, Round, 
    Ne használjatok segítségül Mathf függvényeket, de a sajátjaitokat felhasználhatjátok.
    Lényeg, hogy gyakoroljátok a függvények írását.
    Ezek mehetnek egy skriptbe is. */

    [SerializeField] float a;
    [SerializeField] float b;
    [SerializeField] float value;
    [Space]
    [SerializeField] float min;
    [SerializeField] float max;
    [SerializeField] float abs;
    [SerializeField] float clamp;
    [SerializeField] float clamp01;
    [SerializeField] float sign;
    [SerializeField] float floor;
    [SerializeField] float ceil;
    [SerializeField] float round;


    private void OnValidate()
    {
        min = Minimum(a, b);
        max = Maximum(a, b);
        abs = Abssolute(a);
        clamp = Clamp(value, min, max);
        clamp01 = Clamp01(value);
        sign = Sign(value);
        floor = Floor(value);
        ceil = Ceil(value);
        round = Round(value);

    }

    float Minimum(float n1, float n2)
    {
        if (n1 < n2)
            return n1;
        else
            return n2;
    }

    float Maximum(float n1, float n2)
    {
        if (n1 > n2)
            return n1;
        else
            return n2;
    }

    float Abssolute(float n1)
    {
        if (n1 < 0)
            return -n1; // vagy return n1 * -1

        return n1;
    }

    /* Clamp - A megadott értéket a megadott minimális és maximális float értékek között helyezkedhet el. 
     * A megadott értéket adja vissza, ha az a minimális és maximális tartományon belül van. 
     * A minimális értéket adja vissza, ha az adott float érték kisebb, mint a minimum */
    float Clamp(float n1, float min, float max) 
    {
        if (n1 > min && n1 < max)
            return n1;
        else if (n1 < min)
            return min;
        else
            return max;
    }

    /* Clamp01 - Az értéket 0 és 1 között helyezkedhet el, és értéket ad vissza. 
     * Ha az érték negatív, akkor nullát ad vissza. Ha az érték nagyobb egynél, akkor egyet ad vissza. */
    float Clamp01(float n1) 
    {
        if (n1 < 0)
            return 0;
        else if (n1 > 1)
            return 1;
        else
            return n1;
    }

    /* Sign - amely a szám elõjelét meghatározó egész számot ad vissza */
    float Sign(float n1)
    {
        return n1 = (int)n1;
    }


    //innentõl a megoldókulcsból másoltam

    /* Floor - a legkisebb egész számot adja vissza, amely kisebb vagy egyenlõ, mint a megadott szám */
    float Floor(float n1)
    {
        return n1 - (n1 % 1f);          // mínuszban nem mûködik megfelelõen...pl.: -1.2 = -1, de -2 -nek kellene lennie
    }

    /* Ceil - a legkisebb egész számot adja vissza, amely nagyobb vagy egyenlõ, mint a megadott szám */
    float Ceil(float n1)
    {
        float remainder = n1 % 1f;      // remainder - maradék
        if (remainder == 0)
            return n1;
        else
        return n1 + 1 - remainder;      // mínuszban nem mûködik megfelelõen...pl.: -1.2 = 0, de -1 -nek kellene lennie
    }

    /* Round - egy értéket a legközelebbi egész számra vagy egy adott számú tört számjegyre kerekít */
    float Round(float n1)
    {
        float remainder = n1 % 1f;
        if (remainder <= 0.5)
            return Floor(n1);
        else
        return Ceil(n1);                // mivel a Floor és a Ceil nem mûködnek mínuszban jól, ez sem
    }
}
