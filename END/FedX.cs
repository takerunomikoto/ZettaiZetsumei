using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FedX : MonoBehaviour {
	int X =0,Y=0,Z=0,IF=0;
	float FF=0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (FF < 1f&&IF==0) {
			GameObject T2 = GameObject.Find ("GameClear");
			Text N2 = T2.GetComponent<Text> ();
			N2.color = new Color (1, 1, 0, FF * 1f);
		


			GameObject T3 = GameObject.Find ("Shiro");
			Text N3 = T3.GetComponent<Text> ();
			N3.color = new Color (1, 1, 1, 1f - FF);
			FF+=0.01f;
		}else if (IF == 1 && FF < 1) {
			GameObject T1 = GameObject.Find ("OP");
			Text N1 = T1.GetComponent<Text> ();
			N1.color = new Color (0, 1, 0, 1F * FF);
			FF+=0.02f;
		}
		if (FF > 1 && IF == 0) {
			FF = 0f;
			IF = 1;
		} else if (IF == 2) {
		}
	}
}
