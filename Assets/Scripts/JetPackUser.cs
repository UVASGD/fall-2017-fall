using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JetPackUser : MonoBehaviour {
	public bool jetpack;
	public float fuel;
	public Transform jetPackUI;
	public float jetPackWidth;

	// Use this for initialization
	void Start () {
		jetpack = false;
		fuel = 0f;
		jetPackUI.localScale = new Vector3 (0, jetPackUI.localScale.y, jetPackUI.localScale.z);
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Space)) 
		{
			if (fuel > 0f) {
				fuel -= Time.deltaTime * 20;
				print ("Fuel Level: " + fuel);
				GetComponent <Rigidbody> ().AddForce (new Vector3 (0f, 50f, 0f));
				jetPackUI.localScale = new Vector3 ((fuel / 100f), jetPackUI.localScale.y, jetPackUI.localScale.z);
			} else {
				jetPackUI.localScale = new Vector3 (0, jetPackUI.localScale.y, jetPackUI.localScale.z);
			}
		}

	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.name.Contains("JetPack"))
		{
			jetpack = true;
			fuel = 100f;
			print ("Collected Power Up: JetPack");
			print ("Fuel Level: " + fuel);
			jetPackUI.localScale = new Vector3 (1, jetPackUI.localScale.y, jetPackUI.localScale.z);
		}

	}
}
