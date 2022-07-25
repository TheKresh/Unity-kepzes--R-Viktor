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
    [SerializeField] float interpolatedWithLerpUnclamped;
    [SerializeField] float interpolatedWithLerp;
    [Space]
    [SerializeField] Transform a;
    [SerializeField] Transform b;

    void OnValidate()
    {
        interpolatedWithLerpUnclamped = LerpUnclamped(startValue, endValue, interpolation);
        interpolatedWithLerp = Lerp(startValue, endValue, interpolation);
    }

    private void Update()
    {
        transform.position = Lerp2(a.position, b.position, interpolation); // ERROR-t dobál fel, ha rányomok a PLAY-re
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
    // LerpUnclamped forrás: https://docs.unity3d.com/ScriptReference/Mathf.LerpUnclamped.html

    float Lerp(float num1, float num2, float num3)
    {
        float a = num1 + (num2 - num1) * Mathf.Clamp01(num3); // ilyen formátumban a LerpUnclamped-t is meglehet oldani

        if (a <= 0)
            return 0;
        else if (a >= 1)
            return 1;
        else
            return LerpUnclamped(num1, num2, num3);
    }
    // Lerp forrás: https://docs.unity3d.com/ScriptReference/Mathf.Lerp.html 

    Vector2 Lerp2(Vector2 a, Vector2 b, float num)
    {
        num = Mathf.Clamp01(num);
        return new Vector2(
            a.x + (b.x - a.x) * num,
            a.y + (b.y - a.y) * num
            );
    }
    // Vector2.Lerp forrás: https://docs.unity3d.com/ScriptReference/Vector2.Lerp.html

    // Youtube - [Unity] The Essence of Lerp: https://www.youtube.com/watch?v=WNoizdtEPA4&ab_channel=AcaciaDeveloper

    void OnDrawGizmos()     // kíváncsiság
    {
        Gizmos.color = Color.black;
        Gizmos.DrawWireCube(a.position, new Vector3(0.25f, 0.25f, 0.25f));
        Gizmos.color = Color.black;
        Gizmos.DrawWireCube(b.position, new Vector3(0.25f, 0.25f, 0.25f));
    }
}
