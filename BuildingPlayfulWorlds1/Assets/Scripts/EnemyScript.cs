using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {

	public int EnemyHealth = 10;
	public GameObject TheStoneMonster;

	void DeductPoints (int DamageAmount) {
		EnemyHealth -= DamageAmount;
	}

	void Update () {
		if (EnemyHealth <= 0) {
			this.GetComponent<StoneMonsterFollow>().enabled = false;
			TheStoneMonster.GetComponent<Animation>().Play("Anim_Death");
			StartCoroutine(EndStoneMonster());
		}
	}

	IEnumerator EndStoneMonster() {
		yield return new WaitForSeconds(0.28f);
		Destroy(gameObject);
}
}