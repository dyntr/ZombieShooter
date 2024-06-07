using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int maxHealth = 100; // Maximální zdraví
    public int currentHealth; // Aktuální zdraví
    
  
    private Slider healthSlider;


    void Start()
    {
        currentHealth = maxHealth;
        healthSlider = GetComponentInChildren<Slider>();
        healthSlider.maxValue = maxHealth;
        healthSlider.value = currentHealth;
    }
    public void ApplyDamage(int damage)
    {
        currentHealth -= damage;
        UpdateHealthBar();

        if (currentHealth <= 0)
        {
            Destroy(gameObject);  
        }
    }
    void UpdateHealthBar()
    {
        if (healthSlider)
        {
            healthSlider.value = (float)currentHealth / maxHealth;
        }
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthSlider.value = currentHealth;  // Aktualizuj hodnotu na slideru

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {

        Debug.Log("Nepřítel zemřel");
        GetComponent<EnemyWalk>().Die(); 
        ZombieCounter.instance.ZombieKilled();









    }
}
