using UnityEngine;
using System.Collections;
public class Timer : MonoBehaviour {

	public float timer=180f;
	public Font f;
	int count=0;
	GameObject lightor;
	// Use this for initialization
	void Start () {
		lightor = GameObject.Find ("light");
		lightor.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if (timer <= 0.0f) {
			staticSystem.deadText="逃げ切れなかった。";
			Application.LoadLevel (4);
		}
		timer -= Mathf.Min(timer,Time.deltaTime);
		count++;
		if (count %120 <= 0) {
			GameObject prefab=(GameObject)Resources.Load("Arrow");
			GameObject arrow = (GameObject)GameObject.Instantiate(prefab);
			GameObject arrow2 = (GameObject)GameObject.Instantiate(prefab);
			Vector3 pos = new Vector3(-3.25f,5.1f,-15f);
			arrow.gameObject.transform.localPosition = pos;
			pos = new Vector3(1.77f,5.1f,-15f);
			arrow2.gameObject.transform.localPosition = pos;
		}
		if (count >= 240) {
			count=0;
			GameObject prefab2 = (GameObject)Resources.Load ("Thunder");
			
			// オブジェクトの作成
			GameObject Cuber = (GameObject)GameObject.Instantiate(prefab2);
			// 新しい位置を設定する
			Vector3 pos = new Vector3(38f,0.5f,-6f);
			Cuber.gameObject.transform.localPosition = pos;
			lightor.SetActive(true);

		}
		if(count==60){

			lightor.SetActive(false);
		}
	}
	void OnGUI(){
		GUI.skin.label.fontSize = 36;
		GUI.skin.label.font = f;
		GUI.color = Color.red;
		GUI.Label(new Rect(10,10,170,100),Mathf.FloorToInt(timer/60).ToString("00")+":"+Mathf.FloorToInt(timer%60).ToString("00")+"."+Mathf.FloorToInt(timer%1*100).ToString("00").Substring(0, 2));
		GUI.skin.label.fontSize = 24;
		GUI.color = Color.white;
		GUI.Label (new Rect(10,50,170,30),"↑:前進");
		GUI.Label (new Rect(10,80,170,30),"←→:回転");
		GUI.Label (new Rect(10,110,170,30),"↓:後退");

	}
}
