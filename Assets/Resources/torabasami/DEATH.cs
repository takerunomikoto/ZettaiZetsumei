using UnityEngine;
using System.Collections;

public class DEATH : MonoBehaviour {
	Transform wana1L;
	Transform wana1R;
	bool death=false;
	void Start () {
		wana1L= GameObject.Find("wanaL").GetComponent<Transform>();
		wana1R= GameObject.Find("wanaR").GetComponent<Transform>();
	}
	public void OnTriggerEnter(Collider myCol)
	{
		
		if(myCol.tag=="Player"&&death==false)
		{
			wana1L.transform.Rotate(-90,0,0);
			wana1R.transform.Rotate(-90,0,0);
			death=true;
		}
	}
	void Update(){
		if (death == true) {
			staticSystem.deadText="トラバサミに捕まった。";
				Application.LoadLevel(4);

		}
	}
}
