using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickUp : MonoBehaviour {

	public AudioSource AmmoSound;

	// Use this for initialization
	void OnTriggerEnter (Collider other) {

		AmmoSound.Play();

		if(GlobalAmmo.LoadedAmmo == 0)
		{
			GlobalAmmo.LoadedAmmo += 10;
			this.gameObject.SetActive(false);
		}
		else
		{
			GlobalAmmo.CurrentAmmo += 10;
			this.gameObject.SetActive(false);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
