using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CameraGUIScript : MonoBehaviour {

	public GameObject inv;

	// Use this for initialization
	void Start () {
		guiText.enabled = true;
		guiText.text = "GFDNSKGHJFEKDSJ";
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI()
	{
		int f = 1;
		foreach (GameObject i in inv.GetComponent<InventoryScript>().items) {
			GUI.Label (new Rect (10, 15*f++, 1000, 100),i.GetComponent<ItemData>().getDescription());
		}
	}
}
