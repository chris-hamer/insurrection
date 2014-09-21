using UnityEngine;
using System.Collections;

public class OpenDoor : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {

		if(Input.GetMouseButtonDown(0)){
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			Vector3 fwd = transform.TransformDirection(Vector3.forward);

		}
	}
}
