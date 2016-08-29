using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {

	float SPEED;
	Rigidbody MYBODY;
	Animator anime;
	Vector3 eulerAngleVelocity;
	Quaternion deltaRotation;
	bool keyHori;
	bool keyVer;

	void Start(){
		SPEED = 60f;
		MYBODY = GetComponent<Rigidbody> ();
		anime = GetComponent<Animator> ();
//		MYBODY.position = Vector3.zero;
//		MYBODY.rotation = Quaternion.identity;
		anime.SetBool ("Run",false);
		anime.SetFloat ("Turn",0f);
		anime.SetFloat ("GoBack",0f);
		keyHori = false;
		keyVer = false;
	}

	void FixedUpdate (){
		if (Input.GetAxis ("Horizontal") != 0f) {
			keyHori = true;
		} else {
			keyHori=false;
			anime.SetFloat ("Turn",0f);
		}
		if (Input.GetAxis ("Vertical") != 0f) {
			keyVer = true;
		} else {
			keyVer=false;
			anime.SetFloat ("GoBack",0f);
		}


		if(keyHori==true){
			eulerAngleVelocity=new Vector3(0,Input.GetAxis("Horizontal")*SPEED*2,0);
			deltaRotation = Quaternion.Euler(eulerAngleVelocity * Time.deltaTime);
			MYBODY.MoveRotation(MYBODY.rotation*deltaRotation);
			anime.SetBool ("Run",true);
			if(Input.GetAxis ("Vertical")>=0.5f){
				anime.SetFloat ("Turn",0f);
			}
			else{
				anime.SetFloat ("Turn",1f);
			}
		}
		if (keyVer==true) {
			anime.SetBool ("Run",true);
			if(Input.GetAxis ("Vertical")>0f){
				MYBODY.MovePosition(MYBODY.position+transform.forward*Input.GetAxis ("Vertical")*Mathf.Sqrt(SPEED)/2*Time.deltaTime);
			}
			else{
				MYBODY.MovePosition(MYBODY.position+transform.forward*Input.GetAxis ("Vertical")*Mathf.Sqrt(SPEED)/3*Time.deltaTime);
				anime.SetFloat ("GoBack",1f);
			}
		}
		if (keyHori==false&&keyVer==false) {
			anime.SetBool ("Run",false);
		}
	}
}
