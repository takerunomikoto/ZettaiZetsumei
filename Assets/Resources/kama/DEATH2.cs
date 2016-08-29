using UnityEngine;
using System.Collections;

public class DEATH2 : MonoBehaviour {
	// Use this for initialization

	int Count=60;
	void Start () {
		iTween.RotateTo(gameObject, iTween.Hash("z", 30, "time", 1.0f));
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Count++;
		if (Count%180==0) {
			iTween.RotateTo (gameObject, iTween.Hash ("z", -60, "time", 3.0f));
		
		}
		if (Count%180==90) {
			iTween.RotateTo (gameObject, iTween.Hash ("z", 60, "time", 3.0f));


		}

	}
}
