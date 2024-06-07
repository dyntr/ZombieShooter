using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    private int currentHealth;
    public Slider healthSlider; // Reference na UI Slider

    void Start()
    {
        currentHealth = maxHealth;
        healthSlider.maxValue = maxHealth;
        healthSlider.value = currentHealth; // Nastaví slider na maximální zdraví na začátku hry
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        currentHealth = Mathf.Max(currentHealth, 0); // Zajistí, že zdraví neklesne pod 0
        healthSlider.value = currentHealth; // Aktualizuje slider

        if (currentHealth <= 0)
        {
            // Logika pro smrt hráče
            Debug.Log("Hráč zemřel.");
            SceneManager.LoadScene("GameOver");
        }
    }
}
