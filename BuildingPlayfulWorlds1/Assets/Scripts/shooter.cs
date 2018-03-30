using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooter : MonoBehaviour {
	
	void Update () {

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
