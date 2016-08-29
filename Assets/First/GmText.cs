using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GmText : MonoBehaviour {
	int No =0;
	int Em=0;
	int Am=0;
	float FF=0f;
	float timedes = 4.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			No =11;
		}
		if (No == 0) {
			if (FF <= 1f) {
				FF += 0.02f;
				GameObject T1 = GameObject.Find ("Text (1)");
				Text N1 = T1.GetComponent<Text> ();
				N1.color = new Color (255, 255, 255, FF);
			} else {
				FF = 0;
				No += 1;
			}
		} else if (No == 1) {
			if (FF <= 1f) {
				FF += 0.02f;
				GameObject T2 = GameObject.Find ("Text (2)");
				Text N2 = T2.GetComponent<Text> ();
				N2.color = new Color (255, 255, 255, FF);
			} else {
				FF = 0;
				No += 1;
			}
		} else if (No == 2) {
			if (FF <= 1f) {
				FF += 0.02f;
				GameObject T3 = GameObject.Find ("Text (3)");
				Text N3 = T3.GetComponent<Text> ();
				N3.color = new Color (255, 255, 255, FF);
			} else {
				FF = 0;
				No += 1;
			}
		} else if (No == 3) {
			if (FF <= 1f) {
				FF += 0.02f;
				GameObject T4 = GameObject.Find ("Text (4)");
				Text N4 = T4.GetComponent<Text> ();
				N4.color = new Color (255, 255, 255, FF);
			} else {
				FF = 1;
				No += 1;
			}
		} else if (No == 4) {
			if (timedes <= 0) {
				No += 1;
			}
			timedes -= Time.deltaTime;
		} else if (No == 5) {
			FF -= 0.02f;
			GameObject T1 = GameObject.Find ("Text (1)");
			Text N1 = T1.GetComponent<Text> ();
			N1.color = new Color (255, 255, 255, FF);
			GameObject T2 = GameObject.Find ("Text (2)");
			Text N2 = T2.GetComponent<Text> ();
			N2.color = new Color (255, 255, 255, FF);
			GameObject T3 = GameObject.Find ("Text (3)");
			Text N3 = T3.GetComponent<Text> ();
			N3.color = new Color (255, 255, 255, FF);
			GameObject T4 = GameObject.Find ("Text (4)");
			Text N4 = T4.GetComponent<Text> ();
			N4.color = new Color (255, 255, 255, FF);
			if (FF <= 0) {
				No += 1;
			}
		} else if (No == 6) {
			GameObject obj = GameObject.Find ("CubeA");
			Basn Gm = obj.GetComponent<Basn> ();
			Gm.BlookOn (1);
		} else if (No == 7) {
			if (timedes <= 0) {
				timedes = 1;
			} else {
				timedes -= Time.deltaTime;
				if (timedes <= 0) {
					FF = 0f;
					No += 1;
				}
			}
		} else if (No == 8) {
			FF += 0.0125f;
			GameObject T5 = GameObject.Find ("Text (5)");
			Text N5 = T5.GetComponent<Text> ();
			N5.color = new Color (255, 0, 0, FF);
			if (FF >= 1) {

				No += 1;
				timedes = 2f;
			}
		} else if (No == 9) {
			timedes -= Time.deltaTime;
			if (timedes <= 0) {
				No += 1;
				FF = 1f;

			}
		
		} else if (No == 10) {
			FF -= 0.0125f;
			GameObject T5 = GameObject.Find ("Text (5)");
			Text N5 = T5.GetComponent<Text> ();
			N5.color = new Color (255, 0, 0, FF);
			if(FF <=0){
				No+=1;
			}
		}
		if (No == 11) {
			Application.LoadLevel("Openinng");
		}
	}
	public void AddGmOn(int value){
		No += value;
		GameObject obj = GameObject.Find ("CubeA");
		Basn Gm = obj.GetComponent<Basn> ();
		Gm.BlookOn (0);
	}
}

