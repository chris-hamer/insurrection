using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class InventoryScript : MonoBehaviour {

	public GameObject item;

	public List<GameObject> x = new List<GameObject>();

	// Use this for initialization
	void Start () {
		x.Add ((GameObject) Instantiate (item,Vector3.zero,Quaternion.identity));
		x[0].GetComponent<ItemData> ().setDescription("AHAHAHAHAH");
//		Debug.Log (x[0].GetComponent<ItemData> ().getDescription());
	}
	
	// Update is called once per frame
	void Update () {
	}

	/* Adds an item to the inventory */
	public void add(GameObject newitem) {
		x.Add (newitem);
	}

	/* Removes an item from the inventory. *
	 * Returns the item if the removal was *
	 * sucessful, returns null if the item *
	 * was not found.                      */
	public GameObject remove(GameObject removeditem) {
		if (x.Remove (removeditem))
			return removeditem;
		return null;
	}

	/* Checks if the player has the specified *
	 * item, and returns true if they do.     */
	public bool hasItem(GameObject searchitem) {
		if(x.Contains(searchitem))
			return true;
		return false;
	}
}
