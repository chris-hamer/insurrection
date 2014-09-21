using UnityEngine;
using System.Collections;

public class RoboRailroad : MonoBehaviour {

	public GameObject currentTarget;
	public float speed;
	// Use this for initialization
	void Start () {
		//currentTarget = new GameObject();
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 dir = currentTarget.transform.position - transform.position;
		dir.Normalize();

		rigidbody.AddForce(dir*speed*Time.deltaTime);
	}

	void SetNodeTarget(GameObject target){
		currentTarget = target;
	}
}
