using UnityEngine;
using System.Collections;

public class clear : MonoBehaviour {

	public void OnTriggerEnter(Collider myCol)
	{
		if (myCol.tag == "Player") {
			
			Application.LoadLevel(3);
		}
		
	}
}
