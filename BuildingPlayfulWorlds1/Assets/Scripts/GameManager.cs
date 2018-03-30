using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public static GameManager instance = null;

	public GameObject youWinText;

	void Awake () {
		if (instance == null)
			instance = this;
		else if (instance != null)
			Destroy (gameObject);
	}

	public void Win () {
		youWinText.SetActive(true);
		Time.timeScale = 0.5f;
		SceneManager.LoadScene(0);
	}
}
