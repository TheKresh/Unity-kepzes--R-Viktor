using UnityEngine;

public class DistanceReaction : MonoBehaviour
{
    /* �rj komponenst ami egy Gizmo vonalat rajzol, ami egy m�sik be�ll�that� objektum-ig �r,
    de csak ha egy be�ll�that� hat�r�rt�k alatt van a k�t objektum t�vols�ga.
    Ha k�zel j�r (90% vagy t�bb) a t�vols�g ehhez a hat�r�rt�khez, a vonal sz�ne legyen piros. */

    /* [SerializeField] Transform a;
    [SerializeField] Transform b;
    [SerializeField] Vector3 value;

    void Update()
    {
        float distance = Vector3.Distance(a.position, b.position);
        float enoughDistance = distance < value;
    }

    private void OnDrawGizmos()
    {
        if ()
        {
            Gizmos.color = Color.green;
            Gizmos.DrawLine(a.position, b.position);
        }
        else if ()
        {
            Gizmos.color = Color.red;
            Gizmos.DrawLine(a.position, b.position);
        } */
    } 