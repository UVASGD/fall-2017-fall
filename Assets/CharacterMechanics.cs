using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterMechanics : MonoBehaviour {

	public float terminalSpeed;
	private Vector3 vel;
	// Use this for initialization
	void Start () {
		transform.position = new Vector3 (10f, 0f, 10f);
		print (transform.GetChild (0).transform.name);
		transform.GetChild (0).transform.rotation.eulerAngles.Set (90f, 0f, 0f);
		vel = GetComponent<CharacterController> ().velocity;
		vel = new Vector3 (0, -1f, 0);
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (Mathf.Clamp (transform.position.x, 5f, 15f), transform.position.y, Mathf.Clamp (transform.position.z, 5f, 15f));

		if (Mathf.Approximately(vel.magnitude,0f) && transform.position.y < -10) {
			
		}

		if (vel.magnitude > terminalSpeed) {
			vel = new Vector3 (0, -terminalSpeed, 0);
		}
	}

	void OnControllerColliderHit (ControllerColliderHit other) {
		print ("Controller Collision");
		SceneManager.LoadScene (0);
	}

	void OnCollisionEnter (Collision other) {
		print ("Collision");
		print (other.gameObject.name);

	}
}
