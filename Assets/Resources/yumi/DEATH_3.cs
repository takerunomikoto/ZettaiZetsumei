using UnityEngine;
using System.Collections;

public class DEATH_3: MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
	
		this.transform.Translate(new Vector3(0,0,5)*Time.deltaTime);

	}
	public void OnTriggerEnter(Collider myCol)
	{
		if (myCol.tag == "Player") {
			staticSystem.deadText="弓に撃たれた。";
			Application.LoadLevel(4);
		} else {
			Destroy (this.gameObject);
		}
		
	}
}
