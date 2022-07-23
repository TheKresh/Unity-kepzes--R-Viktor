using UnityEngine;

public class MyMathLerp : MonoBehaviour
{
    /* Írjátok meg a saját verziótokat a következõ függvényekbõl:
    Mathf.LerpUnclamped, Mathf.Lerp, Vector2.Lerp
    Nem véletlenül ebben a sorrendben írtam le a 3 függvényt. 
    Ez a feladat nehezebb lehet, de segíti az algoritmizáló képességet. Kísérletezzetek, gondolkodjatok!
    Matematikai függvények megalkotásánál segíthet ez a weboldal:
    https://www.desmos.com/calculator

    Megoldás segítség:
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
    // LerpUnclamped megoldás forrás: https://docs.unity3d.com/ScriptReference/Mathf.LerpUnclamped.html
}
