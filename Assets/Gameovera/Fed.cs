using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Fed : MonoBehaviour {
	float X =0f; 
	int IF=0;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

		if (IF == 0&&X<=1) {
			X += 0.01f;

			GameObject T2 = GameObject.Find ("GameOvera");
			Text N2 = T2.GetComponent<Text> ();
			N2.color = new Color (255, 255, 255, X*1f);

			GameObject T1 = GameObject.Find ("GetSpace");
			Text N1 = T1.GetComponent<Text> ();
			N1.color = new Color (1, 1, 0.5f, X*1f);
			GameObject T3 = GameObject.Find ("Fed");
			Text N3 = T3.GetComponent<Text> ();
			N3.color = new Color (0, 0, 0, 1f-X);

			GameObject T4 = GameObject.Find ("dtexter");
			Text N4 = T4.GetComponent<Text> ();
			N4.color = new Color (1f, 0, 0, 1f*X);
		}


	}
}
