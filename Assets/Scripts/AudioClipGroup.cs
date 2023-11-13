using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "AudioClipGroup", menuName = "AudioClipGroup", order = 0)]
public class AudioClipGroup : ScriptableObject
{
    [Range(0f, 2f)]
    public float VolumeMin = 1f;
    [Range(0f, 2f)]
    public float VolumeMax = 1f;
    [Range(0f, 2f)]
    public float PitchMin = 1f;
    [Range(0f, 2f)]
    public float PitchMax = 1f;
    public float Cooldown = 0.1f;

    public List<AudioClip> Clips;

    private float timestamp;

    private void OnEnable()
    {
        timestamp = 0;
    }

    public void Play()
    {
        if (AudioSourcePool.Instance == null) return;
        
        Play(AudioSourcePool.Instance.GetSource());
        
    }
    
    public void Play(AudioSource source)
    {
        if (timestamp > Time.time) return;
        if (Clips.Count <= 0) return;

        timestamp += Cooldown;

        source.volume = Random.Range(VolumeMin, VolumeMax);
        source.pitch = Random.Range(PitchMin, PitchMax);
        source.clip = Clips[Random.Range(0, Clips.Count)];
        source.Play();
    }

}
