using UnityEngine;
using System.Collections;

public class PickUpClues : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//lock the mouse cursor in the center of screen 
		Screen.lockCursor = true;
		
		//cast a ray hit from mouse position at mouse down
		if (Input.GetMouseButtonDown (0)) {
			Ray rayFromCamera = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hitInfo;
			
			if(Physics.Raycast(rayFromCamera, out hitInfo, 5.0f)){
				Debug.DrawLine(rayFromCamera.direction, hitInfo.point);
				Debug.Log("casted a ray");
				if (hitInfo.collider.gameObject.tag == "clue"){
					//place the clue in inventory 
					//pause game and read from the clue 
					gameObject.GetComponent<PauseMenu>().Pause();
					//destroy clue object
					Destroy(hitInfo.collider.gameObject);
				}
			}
		}
	}
}
