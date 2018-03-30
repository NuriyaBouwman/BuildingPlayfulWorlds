using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinningBlock : MonoBehaviour {

	void OnTriggerEnter(){
		GameManager.instance.Win();
	}

}
