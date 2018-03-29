using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuOptions : MonoBehaviour {

	public void PlayGame () {
		SceneManager.LoadScene(0);
	}

	public void PlayGameAgain () {
		SceneManager.LoadScene(2);
	}
}
