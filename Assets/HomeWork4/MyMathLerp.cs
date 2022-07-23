using UnityEngine;

public class MyMathLerp : MonoBehaviour
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
    [SerializeField] float interpolated;

    void OnValidate()
    {
        interpolated = LerpUnclamped(startValue, endValue, interpolation);
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
    // LerpUnclamped megold�s forr�s: https://docs.unity3d.com/ScriptReference/Mathf.LerpUnclamped.html
}
