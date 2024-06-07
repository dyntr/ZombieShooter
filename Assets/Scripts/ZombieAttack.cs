using UnityEngine;

public class ZombieAttack : MonoBehaviour
{
    public int attackDamage = 10;

    private void OnCollisionEnter(Collision other)
    {
        PlayerHealth playerHealth = other.gameObject.GetComponent<PlayerHealth>();
        if (playerHealth != null)
        {
            playerHealth.TakeDamage(attackDamage);
        }
    }
}
