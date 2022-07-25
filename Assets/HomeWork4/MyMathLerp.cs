using UnityEngine;

class MyMathLerp : MonoBehaviour
{
    /* �rj�tok meg a saj�t verzi�tokat a k�vetkez� f�ggv�nyekb�l:
    Mathf.LerpUnclamped, Mathf.Lerp, Vector2.Lerp
    Nem v�letlen�l ebben a sorrendben �rtam le a 3 f�ggv�nyt. 
    Ez a feladat nehezebb lehet, de seg�ti az algoritmiz�l� k�pess�get. K�s�rletezzetek, gondolkodjatok!
    Matematikai f�ggv�nyek megalkot�s�n�l seg�thet ez a weboldal:
    https://www.desmos.com/calculator

    Megold�s seg�ts�g:
    https://www.desmos.com/calculator/npnqyhbzie */


    [SerializeField] float startValue;
    [SerializeField] float endValue;
    [SerializeField] float interpolation;
    [Space]
    [SerializeField] float interpolatedWithLerpUnclamped;
    [SerializeField] float interpolatedWithLerp;

    void OnValidate()
    {
        interpolatedWithLerpUnclamped = LerpUnclamped(startValue, endValue, interpolation);
        interpolatedWithLerp = Lerp(startValue, endValue, interpolation);
    }

    float LerpUnclamped(float num1, float num2, float num3)
    {
        float a = num2 - num1;
        float b = a * num3;

        if (num3 < 0)
            return num1 - b;
        else
            return num1 + b;
    }
    // LerpUnclamped forr�s: https://docs.unity3d.com/ScriptReference/Mathf.LerpUnclamped.html

    float Lerp(float num1, float num2, float num3)
    {
        float a = num1 + (num2 - num1) * Mathf.Clamp01(num3);

        if (a <= 0)
            return 0;
        else if (a >= 1)
            return 1;
        else
            return LerpUnclamped(num1, num2, num3);
    }
    /* Lerp forr�s: https://docs.unity3d.com/ScriptReference/Mathf.Lerp.html 
     * Youtube - [Unity] The Essence of Lerp: https://www.youtube.com/watch?v=WNoizdtEPA4&ab_channel=AcaciaDeveloper */
}
