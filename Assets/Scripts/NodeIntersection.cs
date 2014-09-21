using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class NodeIntersection : MonoBehaviour {

	public List<GameObject> connections = new List<GameObject>();

	void Start(){
		//connections = new List<GameObject>();
	}

//	void OnTriggerEnter(Collider collider){
//		if(collider.gameObject.CompareTag("Robot")){
//			Random rnd = new Random();
//
//			Debug.Log(collider.gameObject.ToString());
//
//			collider.gameObject.SendMessage("SetNodeTarget", connections[0]);
//			//collider.gameObject.GetComponent<AIPath>().SetTarget(connections[0]);
//			collider.gameObject.SendMessage("SetState", "Patrol");
//			Debug.Log("Setting new Target");
//		}
//	}

}
