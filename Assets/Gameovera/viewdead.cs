using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class viewdead : MonoBehaviour {
	Text dtext;
	// Use this for initialization
	void Start () {
		dtext = GameObject.Find ("dtexter").GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		dtext.text = staticSystem.deadText;
	}
}
