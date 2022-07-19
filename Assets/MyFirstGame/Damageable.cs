using UnityEngine;

public class Damageable : MonoBehaviour
{
    [SerializeField] int maxHealth = 10;
    public int health = 5; // minden public field automatikusan SerializeField lesz

    void OnTriggerEnter(Collider other)
    {
        Damager damager = other.gameObject.GetComponentInChildren<Damager>();

        if (damager != null && health > 0)
        {
            Debug.Log(other.name);
            health -= Mathf.Min(damager.damage, health);

            health = Mathf.Clamp(health, 0, maxHealth);
        }
    }
}
