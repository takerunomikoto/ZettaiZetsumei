using UnityEngine;
using System.Collections;

public class kidou : MonoBehaviour {

	public void OnTriggerEnter(Collider myCol)
	{
		if (myCol.tag == "Player") {
			
			Rigidbody tama= GameObject.Find("togetama").AddComponent<Rigidbody>();
		}
	}
}
