using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : PersistentSingleton<AudioManager>
{
    [SerializeField] private AudioSource musicAudioSource;
    [SerializeField] private AudioSource effectsAudioSource;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlaySound(AudioClip audioClip)
    {
        effectsAudioSource.PlayOneShot(audioClip);
    }

    public void PlaySound(AudioClip audioClip, float volume)
    {
        effectsAudioSource.PlayOneShot(audioClip, volume);
    }

    public void PlayRandomSound(AudioClip[] audioClips)
    {
        effectsAudioSource.PlayOneShot(audioClips[Random.Range(0, audioClips.Length)]);
    }

    public void PlayRandomSound(AudioClip[] audioClips, float volume)
    {
        effectsAudioSource.PlayOneShot(audioClips[Random.Range(0, audioClips.Length)], volume);
    }

    public void PlayMusic(AudioClip audioClip, float volume)
    {
        if (musicAudioSource.clip == audioClip)
            return;

        musicAudioSource.Stop();
        musicAudioSource.clip = audioClip;
        musicAudioSource.volume = volume;
        musicAudioSource.Play();
    }

    public void PauseMusic()
    {
        musicAudioSource.Pause();
    }

    public void StopMusic()
    {
        musicAudioSource.Stop();
    }

    public void ToggleMusic()
    {
        musicAudioSource.mute = !musicAudioSource.mute;
    }

    public void ToggleEffects()
    {
        effectsAudioSource.mute = !effectsAudioSource.mute;
    }

    public void ChangeMasterVolume(float value)
    {
        AudioListener.volume = value;
    }

    public void ChangeMusicVolume(float value)
    {
        musicAudioSource.volume = value;
    }

    public void ChangeEffectsVolume(float value)
    {
        effectsAudioSource.volume = value;
    }

    public float CalculateVolumeByCollisionForce(float collisionForce, float forceThreshold)
    {
        float volume = 1;

        if (collisionForce <= forceThreshold)
            volume = collisionForce / forceThreshold;
        
        Debug.Log("volume: " + volume);

        return volume;
    }
}
