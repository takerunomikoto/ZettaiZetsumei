using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Space_OP : MonoBehaviour {
	Text t;
	int PA =0;
	float A = 0f;
	// Use this for initialization
	void Start () {
		t = GetComponent<Text> ();
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			Application.LoadLevel("Openinng");
		}
		if (A <= 0) {
			PA = 1;
		} else if(A>=1){
			PA=0;
		}
		if (PA == 1) {
			A += 0.02f;
		} else if (PA == 0) {
			A -= 0.02f;
		}
		t.color = new Color (255f, 255f, 255f, A);
	}
}
