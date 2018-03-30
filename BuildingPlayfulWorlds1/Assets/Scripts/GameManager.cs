using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public static GameManager instance = null;
	public GameObject youWinText;
	public float endgameDelay;

	void Awake(){
		if (instance == null)
			instance = this;
		else if (instance != null)
			Destroy (gameObject);
	}

	public void Win(){

		youWinText.SetActive(true);
		Time.timeScale = 2.0f;
		Invoke ("EndGame", endgameDelay);
	}

	void EndGame(){
		Time.timeScale = 0.6f;
		SceneManager.LoadScene(2);
	}
}
