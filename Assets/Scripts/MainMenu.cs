using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public AudioClip clickSound;
    private AudioSource audioSource;

    public float volumeMultiplier = 1.5f;
    public float delay = 0.5f;

    void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        audioSource = GetComponent<AudioSource>();


        if (audioSource != null)
        {
            audioSource.volume *= volumeMultiplier;
        }
    }

    public void StartGame()
    {
        PlayClickSoundWithDelay();
        Invoke("LoadLevel1", delay);
    }

    public void MenuBTN()
    {
        PlayClickSoundWithDelay();
        Invoke("LoadMenu", delay);
    }

    public void ExitGame()
    {
        PlayClickSoundWithDelay();
        Invoke("QuitGame", delay);
    }

    private void PlayClickSoundWithDelay()
    {
        if (clickSound != null && audioSource != null)
        {
            audioSource.PlayOneShot(clickSound);
        }
    }

    private void LoadLevel1()
    {
        SceneManager.LoadScene("Level1");
    }

    private void LoadMenu()
    {
        SceneManager.LoadScene("MENU");
    }

    private void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit(); 
#endif
    }
}
