using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public AudioClipGroup StoneDropAudio;
    public AudioClipGroup IronDropAudio;
    public AudioClipGroup UraniumDropAudio;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Debug.Log("Alpha1");
            StoneDropAudio.Play();
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Debug.Log("Alpha2");
            IronDropAudio.Play();
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Debug.Log("Alpha3");
            UraniumDropAudio.Play();
        }
    }
}