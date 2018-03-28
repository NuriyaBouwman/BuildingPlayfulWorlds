using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour {

    private AudioSource windSource;

    public AudioClip[] soundClips;

	// Use this for initialization
	void Start () {
        windSource = (AudioSource)GetComponent(typeof(AudioSource));

        windSource.Play();
	}

    void OnTriggerEnter(Collider collider)
    {
        AudioClip randomClip = soundClips[Random.Range(0, soundClips.Length)];

        windSource.clip = randomClip;
        windSource.Play();
    }
    // Update is called once per frame
    void Update () {
		
	}
}
