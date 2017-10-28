using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterMovement : MonoBehaviour {
	Rigidbody rb;
	float thrust = (float) 30.0;
	Vector3 target;
	// Use this for initialization
	void Start () {
		transform.position = new Vector3 (10f, 0f, 10f);
		transform.GetChild (0).transform.rotation.eulerAngles.Set (90f, 0f, 0f);
		rb = GetComponent<Rigidbody> ();

		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (Mathf.Clamp (transform.position.x, 5f, 15f), transform.position.y, Mathf.Clamp (transform.position.z, 5f, 15f));
		target = new Vector3 (Input.GetAxis ("Horizontal"), 0, Input.GetAxis("Vertical")).normalized * thrust;
		rb.velocity = new Vector3 (target.x, rb.velocity.y, target.z);

	}

	void OnCollisionEnter(Collision other){
		SceneManager.LoadScene (0);
	}
		
}
