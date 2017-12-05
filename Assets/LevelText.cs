using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelText : MonoBehaviour {
	public Text levelText;
	public bool entered;
	// Use this for initialization
	void Start () {
		entered = false;
		levelText.color = new Vector4 (levelText.color.r, levelText.color.g, levelText.color.b, 0f);
		levelText.text = "LEVEL 1";
	}
	
	// Update is called once per frame
	void Update () {
		print (entered);
		if (!entered) {
			print ("something");
			levelText.color = new Vector4 (levelText.color.r, levelText.color.g, levelText.color.b, levelText.color.a + Time.deltaTime);
			print (levelText.color.a);
			if (levelText.color.a >= 3) {
				entered = true;
				print ("entered=true");
				print (levelText.color.a);
			}
		} else {
			if (levelText.color.a > 0) {
				levelText.color = new Vector4 (levelText.color.r, levelText.color.g, levelText.color.b, levelText.color.a - Time.deltaTime);
			}
		}

	}
}
