using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class InventoryScript : MonoBehaviour {

	public GameObject item;

	public List<GameObject> items = new List<GameObject>();

	// Use this for initialization
	void Start () {
		items.Add ((GameObject) Instantiate (item,Vector3.zero,Quaternion.identity));
		items[0].GetComponent<ItemData> ().setDescription("AHAHAHAHAH");
		items.Add ((GameObject) Instantiate (item,Vector3.zero,Quaternion.identity));
		items[1].GetComponent<ItemData> ().setDescription("THE SECOND ITEM");
		items.Add ((GameObject) Instantiate (item,Vector3.zero,Quaternion.identity));
		items[2].GetComponent<ItemData> ().setDescription("OH GOD WE HAVE THREE ITEMS");
//		Debug.Log (x[0].GetComponent<ItemData> ().getDescription());
	}
	
	// Update is called once per frame
	void Update () {
	}

	/* Adds an item to the inventory */
	public void add(GameObject newitem) {
		items.Add (newitem);
	}

	/* Removes an item from the inventory. *
	 * Returns the item if the removal was *
	 * sucessful, returns null if the item *
	 * was not found.                      */
	public GameObject remove(GameObject removeditem) {
		if (items.Remove (removeditem))
			return removeditem;
		return null;
	}

	/* Checks if the player has the specified *
	 * item, and returns true if they do.     */
	public bool hasItem(GameObject searchitem) {
		if(items.Contains(searchitem))
			return true;
		return false;
	}
}
