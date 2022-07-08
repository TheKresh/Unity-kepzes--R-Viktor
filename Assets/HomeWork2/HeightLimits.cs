using UnityEngine;

public class HeightLimits : MonoBehaviour
{
    /* Írjatok komponenst, ami nem engedi, hogy a gameObject-je 2 beállítható határérték alá vagy fölé kerüljön.
     * (Update-ben megnézi, hogy kint van-e a tartományon és ha igen, bejjebb teszi.) */
    
    [SerializeField] int minimum;
    [SerializeField] int maximum;

    void Update()
    {
        Vector3 position = transform.position;

        if (position.y < minimum)
            position.y = minimum;
        else if (position.y > maximum)
            position.y = maximum;

        transform.position = position;
    }
}
// Play után - ha az objectnek, jelen esetben az Y pozícióját a minimum és a maximum határértéken kívülre állítom, akkor azonnal visszadobja a határértéken bellülre
