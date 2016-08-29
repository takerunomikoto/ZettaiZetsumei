using UnityEngine;
using System.Collections;

public class wana5 : MonoBehaviour {
	bool death=false;
	byte iCount=0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (death == true) {

				Application.LoadLevel(4);
					}
	}
	public void OnTriggerEnter(Collider myCol)
	{
		if (myCol.tag == "Player") {
			GameObject prefab = (GameObject)Resources.Load ("Thunder");
			GameObject than = (GameObject)GameObject.Instantiate(prefab);

			// 新しい位置を設定する
			Vector3 pos = this.gameObject.transform.localPosition;

			than.gameObject.transform.localPosition = pos;
			death = true;
			staticSystem.deadText="雷に撃たれた。";
		}
	}
}
