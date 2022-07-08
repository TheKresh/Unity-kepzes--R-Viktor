using UnityEngine;

public class MyMath : MonoBehaviour
{
    /* N�zzetek ut�na a k�vetkez� Mathf f�ggv�nyeknek �s �rj�tok meg a saj�t verzi�tokat bel�l�k:
    Max, Min, Clamp, Clamp01, Abs, Sign, Floor, Ceil, Round, 
    Ne haszn�ljatok seg�ts�g�l Mathf f�ggv�nyeket, de a saj�tjaitokat felhaszn�lhatj�tok.
    L�nyeg, hogy gyakorolj�tok a f�ggv�nyek �r�s�t.
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

    /* Clamp - A megadott �rt�ket a megadott minim�lis �s maxim�lis float �rt�kek k�z�tt helyezkedhet el. 
     * A megadott �rt�ket adja vissza, ha az a minim�lis �s maxim�lis tartom�nyon bel�l van. 
     * A minim�lis �rt�ket adja vissza, ha az adott float �rt�k kisebb, mint a minimum */
    float Clamp(float n1, float min, float max) 
    {
        if (n1 > min && n1 < max)
            return n1;
        else if (n1 < min)
            return min;
        else
            return max;
    }

    /* Clamp01 - Az �rt�ket 0 �s 1 k�z�tt helyezkedhet el, �s �rt�ket ad vissza. 
     * Ha az �rt�k negat�v, akkor null�t ad vissza. Ha az �rt�k nagyobb egyn�l, akkor egyet ad vissza. */
    float Clamp01(float n1) 
    {
        if (n1 < 0)
            return 0;
        else if (n1 > 1)
            return 1;
        else
            return n1;
    }

    /* Sign - amely a sz�m el�jel�t meghat�roz� eg�sz sz�mot ad vissza */
    float Sign(float n1)
    {
        return n1 = (int)n1;
    }


    //innent�l a megold�kulcsb�l m�soltam

    /* Floor - a legkisebb eg�sz sz�mot adja vissza, amely kisebb vagy egyenl�, mint a megadott sz�m */
    float Floor(float n1)
    {
        return n1 - (n1 % 1f);          // m�nuszban nem m�k�dik megfelel�en...pl.: -1.2 = -1, de -2 -nek kellene lennie
    }

    /* Ceil - a legkisebb eg�sz sz�mot adja vissza, amely nagyobb vagy egyenl�, mint a megadott sz�m */
    float Ceil(float n1)
    {
        float remainder = n1 % 1f;      // remainder - marad�k
        if (remainder == 0)
            return n1;
        else
        return n1 + 1 - remainder;      // m�nuszban nem m�k�dik megfelel�en...pl.: -1.2 = 0, de -1 -nek kellene lennie
    }

    /* Round - egy �rt�ket a legk�zelebbi eg�sz sz�mra vagy egy adott sz�m� t�rt sz�mjegyre kerek�t */
    float Round(float n1)
    {
        float remainder = n1 % 1f;
        if (remainder <= 0.5)
            return Floor(n1);
        else
        return Ceil(n1);                // mivel a Floor �s a Ceil nem m�k�dnek m�nuszban j�l, ez sem
    }
}
