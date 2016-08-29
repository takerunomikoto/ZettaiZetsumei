using UnityEngine;
using System.Collections;

public class DEATH2_1 : MonoBehaviour {
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
		
		if(myCol.tag=="Player"&&death==false)
		{
			staticSystem.deadText="カマに斬り付けられた。";
			death=true;
		}
	}
}
