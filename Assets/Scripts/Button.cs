using UnityEngine;
using System.Collections;
using System;

public class Button : MonoBehaviour {

    public string input_key;
    public string color_name;

    private BlockSelector blockSelector;

	// Use this for initialization
	void Start () {
        blockSelector = FindObjectOfType<BlockSelector>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(input_key))
        {
            blockSelector.SelectedColor = color_name;
            print("Selected new color " + color_name);
        }
    }
}
