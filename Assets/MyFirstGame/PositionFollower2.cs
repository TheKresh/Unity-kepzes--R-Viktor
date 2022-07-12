using UnityEngine;

public class PositionFollower2 : MonoBehaviour
{
    [SerializeField] Transform followable;
    // [SerializeField] float speed;
    [SerializeField] AnimationCurve speedOverDistance;
    [SerializeField] float regenerateSpeed;

    [SerializeField] float startStamina = 1;
    float stamina;
    bool regenerating = false;

    private void Start()
    {
        stamina = startStamina;
    }

    void Update()
    {
        // Debug.Log(enabled);  - ezzel lekerdezzuk hogy bevan e kapcsolva a follower


        if (followable == null)     // null tesztnek nevezzuk
            return;
        if (regenerating)        // ha elfogy a stamina alljon meg az enemy
        {
            Regenerate();
        }
        else
        {
            Move();
        }
        Debug.Log(stamina);
    }

    private void Regenerate()
    {
        stamina += Time.deltaTime * regenerateSpeed;
        if (stamina >= startStamina)
        {
            regenerating = false;
            stamina = startStamina;
        }
    }

    private void Move()
    {
        float distance = Vector3.Distance(followable.position, transform.position);     // vagy float distance = (followable.position, transform.position).magnitude;

        float speed = speedOverDistance.Evaluate(distance);
        Vector3 startPos = transform.position;
        transform.position = Vector3.MoveTowards(
            transform.position, followable.position, speed * Time.deltaTime);
        Vector3 endPos = transform.position;

        float step = (endPos - startPos).magnitude;

        Vector3 vectorPointingToTarget = followable.position - transform.position;
        transform.rotation = Quaternion.LookRotation(vectorPointingToTarget);

        stamina -= step;
        if (stamina <= 0)
        {
            regenerating = true;
            stamina = 0;    // vagy stamina = Mathf.Max(0, stamina);
        }
    }
}
