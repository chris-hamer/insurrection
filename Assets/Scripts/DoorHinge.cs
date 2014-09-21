using UnityEngine;
using System.Collections;

public class DoorHinge : MonoBehaviour {

	public string state;

	float opentimer;
	Vector3 openposition;
	Vector3 closedposition;
	void Start(){
		closedposition = transform.position;
		openposition = new Vector3(transform.position.x, transform.position.y + 10,  transform.position.z);

		state = "closed";
	}

	void SetDoorState(string newState){
		state = newState;
	}

	// Update is called once per frame
	void Update () {
		if(state == "open"){
			opentimer -= Time.deltaTime;
			if(opentimer <= 0){
				state = "closing";
			}
		}

		if(state == "closing"){
			if(!transform.position.Equals(closedposition)){
				transform.position = Vector3.Lerp(transform.position, closedposition, 1.0f);
			}
			if(transform.position == closedposition){
				state = "closed";
			}
		}

		if(state == "opening"){
		}
	}
}
