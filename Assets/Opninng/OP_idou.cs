using UnityEngine;
using System.Collections;

public class OP_idou : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown (KeyCode.Space)){
			Application.LoadLevel(2);
		}
		if(Input.GetKeyDown (KeyCode.LeftShift)||Input.GetKeyDown (KeyCode.RightShift)){
			Application.LoadLevel(5);
		}
	}
}
