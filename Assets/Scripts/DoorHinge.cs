using UnityEngine;
using System.Collections;

public class DoorHinge : MonoBehaviour {

	public GameObject doorObj;
	public string state;
//	public float maxOpening;
//	public float maxRotationX;
//	public float startRotation;
	public float opentime;
	public float openheight;
	public Vector3 openposition;
	public Vector3 closedposition;
	void Start(){
		closedposition = doorObj.transform.position;
		openposition = new Vector3(doorObj.transform.position.x, doorObj.transform.position.y + openheight, doorObj.transform.position.z);
	}

	void SetDoorState(string newState){
		state = newState;
	}

	// Update is called once per frame
	void Update () {
		if(state == "opened"){

		}
		if(state == "closed"){

		}
		if(state == "closing"){
			doorObj.transform.position = Vector3.Lerp(doorObj.transform.position, closedposition, opentime);
			if(doorObj.transform.position == closedposition){

			}
		}
		if(state == "opening"){
			doorObj.transform.position = Vector3.Lerp(doorObj.transform.position, closedposition, opentime);
		}
	}
}
