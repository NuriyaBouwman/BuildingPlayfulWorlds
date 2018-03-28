using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPickup : MonoBehaviour {

	private GameObject pickupableObject;

	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetMouseButtonDown(1))
		{
			if(pickupableObject == null)
			{
				int layer = LayerMask.NameToLayer("PickUpable");
				RaycastHit hitInfo;
				if(Physics.Raycast(transform.position + transform.forward, transform.forward, out hitInfo, 3.0f, 1 << layer))
				{
					pickupableObject = hitInfo.collider.gameObject;
					pickupableObject.transform.parent = transform;

					((Rigidbody)pickupableObject.GetComponent(typeof(Rigidbody))).isKinematic = true;
				}
			}
			else
			{
				((Rigidbody)pickupableObject.GetComponent(typeof(Rigidbody))).isKinematic = false;

				pickupableObject.transform.parent = null;

				pickupableObject = null;
			}
		}
	}
}
