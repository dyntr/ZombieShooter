using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public int damage = 20;

    public void Initialize(Vector3 direction)
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.velocity = direction * speed;
    }

    void OnTriggerEnter(Collider hitInfo)
    {
        Debug.Log("Náboj zasáhl: " + hitInfo.name);
        Health enemy = hitInfo.GetComponent<Health>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
            Destroy(gameObject); // Zničí náboj po zásahu
        }
    }
}
