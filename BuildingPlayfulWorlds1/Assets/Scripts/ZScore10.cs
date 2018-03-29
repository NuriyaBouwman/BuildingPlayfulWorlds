using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZScore10 : MonoBehaviour {

	// Use this for initialization
	void DeductPoints (int DamageAmount) {
		GlobalScore.CurrentScore += 10;
	}
}
