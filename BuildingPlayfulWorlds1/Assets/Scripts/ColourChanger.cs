using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourChanger : MonoBehaviour {

    public Color cubeColour = new Color();

    public Renderer cubeRenderer;

	// Use this for initialization
	void Start () {
        cubeRenderer.material.color = cubeColour;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
