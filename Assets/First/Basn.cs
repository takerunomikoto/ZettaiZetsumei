using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Basn : MonoBehaviour {
	int On =0;
	float TF = 1.0f;
	// Use this for initialization
	void Start () {
	
	}
	public void BlookOn(int value){
		On = value;
	}
	// Update is called once per frame
	void Update () {
		if (On == 1) {
			if (TF <= 0) {
				this.transform.position = new Vector3 (-2f, 3f, 0f);
				GameObject obj = GameObject.Find ("Canvas");
				GmText Gm = obj.GetComponent<GmText>();
				Gm.AddGmOn(1);
			} else {
				TF -= Time.deltaTime;
			}
		}
	}
}
