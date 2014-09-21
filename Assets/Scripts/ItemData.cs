using UnityEngine;
using System.Collections;

public class ItemData : MonoBehaviour {
	
	public string name = "LOOK AT ME IM A NAME";
	public string description = "LOOK AT ME IM A DESCRIPTION";
	public string icon = "LOOK AT ME IM AN ICON";

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public string getDescription() {
		return description;
	}
	
	public void setDescription(string newdescription) {
		description = string.Copy (newdescription);
	}

	public string getIcon() {
		return icon;
	}
	
	public void setIcon(string newicon) {
		icon = string.Copy (newicon);
	}

	public string getName() {
		return name;
	}
	
	public void setName(string newname) {
		name = string.Copy (newname);
	}
}
