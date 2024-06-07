using UnityEngine;
using System.Collections.Generic;

public class SoundComponent : MonoBehaviour
{
    public AudioSource backgroundMusicSource;
    public AudioSource soundEffectSource;
    public AudioClip backgroundMusicClip;

    [System.Serializable]
    public class SoundEffect
    {
        public string name;
        public AudioClip clip;
    }

    public List<SoundEffect> soundEffects = new List<SoundEffect>();

    private Dictionary<string, AudioClip> soundEffectsMap = new Dictionary<string, AudioClip>();

    void Start()
    {
        foreach (var soundEffect in soundEffects)
        {
            if (!soundEffectsMap.ContainsKey(soundEffect.name))
            {
                soundEffectsMap.Add(soundEffect.name, soundEffect.clip);
            }
            else
            {
                Debug.LogWarning("Sound with name " + soundEffect.name + " already exists in the map.");
            }
        }
        PlayBackgroundMusic(backgroundMusicClip);
    }

    public void PlaySoundEffect(string soundName)
    {
        if (soundEffectsMap.ContainsKey(soundName))
        {
            soundEffectSource.PlayOneShot(soundEffectsMap[soundName]);
        }
        else
        {
            Debug.LogWarning("Sound with name " + soundName + " not found in the map.");
        }
    }

    public void PlayBackgroundMusic(AudioClip musicClip, bool loop = true)
    {
        if (backgroundMusicSource != null && musicClip != null)
        {
            backgroundMusicSource.volume = 0.02f;
            backgroundMusicSource.clip = musicClip;
            backgroundMusicSource.loop = loop;
            backgroundMusicSource.Play();
            
        }
    }

    public void StopBackgroundMusic()
    {
        if (backgroundMusicSource != null)
        {
            backgroundMusicSource.Stop();
        }
    }
}
