using UnityEngine;
using System.Collections;

public class EnemyDetection : MonoBehaviour {

	GameObject Player;
	public GameObject Parent;
	public float distance = 12.0f;
	Vector3 EnemyPos;
	Vector3 PlayerPos;

	float EnemyXPos;
	float EnemyYPos;
	float EnemyZPos;

	float PlayerXPos;
	float PlayerYPos;
	float PlayerZPos;

	public float enemyFieldOfView;
	

	// Use this for initialization
	void Start () {
		Player = GameObject.FindGameObjectWithTag ("Player");

	}
	
	// Update is called once per frame
	void Update () {
		EnemyPos = transform.position;
		PlayerPos = Player.transform.position;

		EnemyXPos = transform.position.x;
		EnemyYPos = transform.position.y;
		EnemyZPos = transform.position.z;

		PlayerXPos = PlayerPos.x;
		PlayerYPos = PlayerPos.y;
		PlayerZPos = PlayerPos.z;

		float directionMagnitude = (EnemyPos - PlayerPos).magnitude;
		Vector3 direction = new Vector3((PlayerXPos - EnemyXPos) / directionMagnitude, (PlayerYPos - EnemyYPos) / directionMagnitude, (PlayerZPos - EnemyZPos) / directionMagnitude);
		Ray rayOrigin = new Ray(transform.position, direction);
		RaycastHit hitInfo;

		//update the angle between foward ray to hit ray for player
		float angle = Vector3.Angle(direction, transform.forward);

		//center ray
		Debug.DrawRay (transform.position, transform.forward, Color.cyan);

		if (Physics.Raycast(rayOrigin, out hitInfo, distance))
		{
			Debug.DrawRay(transform.position, direction * directionMagnitude);
			if (hitInfo.transform.tag == "Wall")
			{
				//do nothing and continue scheduled path
				Parent.SendMessage("SetState", "Return");
				//Debug.Log ("Enemy' sight is blocked by a wall");
			}
			
			if ((hitInfo.transform.gameObject == Player) && (angle < enemyFieldOfView * 0.5f))
			{
				//start the path finding function
				Parent.SendMessage("SetState", "Chase");

				//Debug.Log("Enemy found the player");
			}
			if(hitInfo.Equals(null)){
				Parent.SendMessage("SetState", "Patrol");
			}

 		}

	} 
}
