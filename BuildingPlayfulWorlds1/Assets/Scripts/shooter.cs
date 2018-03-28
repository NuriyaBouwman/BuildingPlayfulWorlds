﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooter : MonoBehaviour {

    public GameObject bulletPrefab;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

         if (Input.GetMouseButtonDown(1))
        {
            GameObject bullet = Instantiate(bulletPrefab, transform.position + transform.forward, Quaternion.identity);
            Rigidbody bulletRigidbody = (Rigidbody)bullet.GetComponent(typeof(Rigidbody));

           	bulletRigidbody.AddForce(transform.forward * 50.0f, ForceMode.Force);
        }

        if(Input.GetMouseButtonDown(0))
        {
            RaycastHit hitInfo;
            if(Physics.Raycast(transform.position + transform.forward, transform.forward, out hitInfo))
            {
                if(hitInfo.collider.gameObject.name == "Target")
                {
                    Destroy(hitInfo.collider.gameObject);
                }
            }
        }
	}
}
