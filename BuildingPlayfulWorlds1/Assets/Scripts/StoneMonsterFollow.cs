using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneMonsterFollow : MonoBehaviour {

	public GameObject ThePlayer;
	public float TargetDistance;
	public float AllowedRange = 20;
	public GameObject TheEnemy;
	public float EnemySpeed;
	public int AttackTrigger;
	public RaycastHit Shot;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt(ThePlayer.transform);
		if (Physics.Raycast (transform.position, transform.TransformDirection(Vector3.forward), out Shot)) {
			TargetDistance = Shot.distance;
			if (TargetDistance < AllowedRange) {
				EnemySpeed = 0.07f;
				if (AttackTrigger == 0) {
					TheEnemy.GetComponent<Animation>().Play("Anim_Run");
					transform.position = Vector3.MoveTowards(transform.position, ThePlayer.transform.position, EnemySpeed);
				}
			}
			else {
				EnemySpeed = 0;
				TheEnemy.GetComponent<Animation>().Play("Anim_Idle");
			}
		}

		if(AttackTrigger == 1) {
			TheEnemy.GetComponent<Animation>().Play("Anim_Attack");
		}
	}

	void OnTriggerEnter(){
		AttackTrigger = 1;
	}

	void OnTriggerExit(){
		AttackTrigger = 0;
	}
}
