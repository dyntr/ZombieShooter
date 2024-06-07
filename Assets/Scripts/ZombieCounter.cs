using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ZombieCounter : MonoBehaviour
{
    public static ZombieCounter instance;
    public TextMeshProUGUI zombieCountText;
    public int totalZombies = 10;
    private int remainingZombies;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }

        remainingZombies = totalZombies;
        UpdateZombieCounter();
    }

    public void ZombieKilled()
    {
        remainingZombies--;
        UpdateZombieCounter();
        if (remainingZombies == 0)
        {
            SceneManager.LoadScene("Level2");
        }
    }
    void UpdateZombieCounter()
    {
        zombieCountText.text = "Zombies Remaining: " + remainingZombies + "/" + totalZombies;
    }
}
