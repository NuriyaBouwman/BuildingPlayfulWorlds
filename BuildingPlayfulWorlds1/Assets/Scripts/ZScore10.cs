﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZScore10 : MonoBehaviour {

	void DeductPoints (int DamageAmount) {
		GlobalScore.CurrentScore += 10;
	}
}
