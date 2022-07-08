using UnityEngine;

public class HeightLimits : MonoBehaviour
{
    /* �rjatok komponenst, ami nem engedi, hogy a gameObject-je 2 be�ll�that� hat�r�rt�k al� vagy f�l� ker�lj�n.
     * (Update-ben megn�zi, hogy kint van-e a tartom�nyon �s ha igen, bejjebb teszi.) */
    
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
// Play ut�n - ha az objectnek, jelen esetben az Y poz�ci�j�t a minimum �s a maximum hat�r�rt�ken k�v�lre �ll�tom, akkor azonnal visszadobja a hat�r�rt�ken bell�lre
