using UnityEngine;
using System.Collections;

public class togw2 : MonoBehaviour {

	// Use this for initialization
	public void OnCollisionEnter(Collision myCol)
	{
		if (myCol.gameObject.tag == "Player") {
			GameObject.Find("toge2").transform.localPosition=this.transform.localPosition;
			staticSystem.deadText="トゲに刺された。";
			Application.LoadLevel(4);
		}
	}
}
