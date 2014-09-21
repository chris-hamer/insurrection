using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AIRobotPatrol : MonoBehaviour {

	public GameObject _target;
	public GameObject _targetNode;
	public GameObject Player;
	public List<GameObject> patrolNodes;
	public string _aiState;

	// Use this for initialization
	void Start () {
		patrolNodes = SortObjectsByDistance(patrolNodes);
		Debug.Log(patrolNodes.ToString());
		_targetNode = patrolNodes[0];
		if(_aiState == "Patrol"){
			gameObject.SendMessage("SetTarget", _targetNode);
		}
	}

	void SetState(string state){
		_aiState = state;
	}

	void SetTarget(GameObject obj){
		_target = obj;
	}
	void SetNodeTarget(GameObject obj){
		_targetNode = obj;
	}

	List<GameObject> SortObjectsByDistance(List<GameObject> list){
		List<GameObject> temp = new List<GameObject>();
		for(int i = 0; i < list.Count; i++){
			temp.Add(list[i]);
		}
		
		bool swapped = false;
		do
		{
			for(int i = 1; i < temp.Count; i++)
			{
				if(Vector3.Distance(temp[i].transform.position, transform.position) < Vector3.Distance(temp[i-1].transform.position, transform.position))
				{
					GameObject tmp = temp[i];
					temp[i] = temp[i-1];
					temp[i-1] = tmp;
					swapped = true;
				}
			}
		} while(!swapped);
		return temp;
	}

	void OnTriggerEnter(Collider other) {
		Debug.Log ("GFADHJGNDSKHJKDFAHGKLFESJA");
		SetNodeTarget (other.gameObject.GetComponent<NodeIntersection> ().connections [0]);
	}

	public void theRobotHitANodeAndNowWeGottaDealWithIt() {

	}

	// Update is called once per frame
	void Update () {
		if(_aiState == "Idle"){
			gameObject.GetComponent<AIPath>().canMove = false;
			gameObject.SendMessage("SetTarget", null);
		}
		if(_aiState == "Chase"){
			gameObject.SendMessage("SetTarget", Player);
		}
		if(_aiState == "Patrol"){
			gameObject.SendMessage("SetTarget", _targetNode);
			Debug.Log(_targetNode.ToString());
		}
		if(_aiState == "Return"){
			gameObject.SendMessage("SetTarget", _targetNode);
		}
	}
}
