using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform player;
    public bool isDead = false;

    public AudioSource deathSound; // Zvukový zdroj pro zvuk smrti
    public AudioClip deathClip; // Zvukový soubor pro smrt

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        if (!isDead)
        {
            agent.SetDestination(player.position);
        }
    }

    public void Die() // Voláno z jiného skriptu při smrti
    {

        deathSound.PlayOneShot(deathClip);
        isDead = true;
        agent.isStopped = true; // Zastaví NavMeshAgenta
        this.gameObject.SetActive(false);

    }
}
