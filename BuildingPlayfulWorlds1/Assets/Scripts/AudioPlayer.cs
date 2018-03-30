using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour {

    private AudioSource windSource;

    public AudioClip[] soundClips;

	void Start () {
        windSource = (AudioSource)GetComponent(typeof(AudioSource));

        windSource.Play();
	}
}
