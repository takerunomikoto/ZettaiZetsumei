using UnityEngine;
using System.Collections;

public class wana_4 : MonoBehaviour {

	public void OnCollisionEnter(Collision myCol)
	{
		if (myCol.gameObject.tag == "Player") {
			staticSystem.deadText="ハリ玉に刺し潰された。";
			Application.LoadLevel(4);
		}
	}
}
