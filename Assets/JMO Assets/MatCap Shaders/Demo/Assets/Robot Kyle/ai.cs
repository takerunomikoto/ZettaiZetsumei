using UnityEngine;
using System.Collections;

public class ai : MonoBehaviour {
	int State=0;
	void Update () {
		if (State == 0) {
			this.transform.Translate (new Vector3 (0, 0, 2f) * Time.deltaTime);
			if (this.transform.localPosition.x < -5.5f)
				State = 1;
		} else if (State == 1) {
			this.transform.Rotate (new Vector3 (0, 50f, 0) * Time.deltaTime);
			if (this.transform.eulerAngles.y >= 359f) {
				State = 2;
			}

		} else if (State == 2) {
			this.transform.Translate (new Vector3 (0, 0, 2f) * Time.deltaTime);
			if (this.transform.localPosition.z > 10f)
				State = 3;
		} else if (State == 3) {
			this.transform.Rotate (new Vector3 (0, 50f, 0) * Time.deltaTime);
			if (this.transform.eulerAngles.y <= 90f && this.transform.eulerAngles.y > 89f) {
				State = 4;
			}
		} else if (State == 4) {
			this.transform.Translate (new Vector3 (0, 0, 2f) * Time.deltaTime);
			if (this.transform.localPosition.x > 8f)
				State = 5;
		} else if (State == 5) {
			this.transform.Rotate (new Vector3 (0, 50f, 0) * Time.deltaTime);
			if (this.transform.eulerAngles.y <= 270f && this.transform.eulerAngles.y > 269f) {
				State = 6;
			}
		}
		else if (State == 6) {
			this.transform.Translate (new Vector3 (0, 0, 2f) * Time.deltaTime);
			if (this.transform.localPosition.x < -5.5f)
				State = 7;
		}
		else if (State == 7) {
			this.transform.Rotate (new Vector3 (0, -50f, 0) * Time.deltaTime);
			if (this.transform.eulerAngles.y <= 180f && this.transform.eulerAngles.y > 179f) {
				State = 8;
			}
		}
		else if (State == 8) {
			this.transform.Translate (new Vector3 (0, 0, 2f) * Time.deltaTime);
			if (this.transform.localPosition.z < -10f)
				State = 9;
		}
		else if (State == 9) {
			this.transform.Rotate (new Vector3 (0, -50f, 0) * Time.deltaTime);
			if (this.transform.eulerAngles.y <= 90f && this.transform.eulerAngles.y > 89f) {
				State = 10;
			}
		}
		else if (State == 10) {
			this.transform.Translate (new Vector3 (0, 0, 2f) * Time.deltaTime);
			if (this.transform.localPosition.x > 8f)
				State = 11;
		}
		else if (State == 11) {
			this.transform.Rotate (new Vector3 (0, 50f, 0) * Time.deltaTime);
			if (this.transform.eulerAngles.y <= 270f && this.transform.eulerAngles.y > 269f) {
				State = 0;
			}
		}
//		} else {
//			this.transform.Translate (new Vector3 (0, 0, 0.5f) * Time.deltaTime);
//			if (this.transform.localPosition.z > 20f)
//				Destroy (this.gameObject);
//		}
	}
	public void OnTriggerEnter(Collider myCol)
	{
		if (myCol.tag == "Player") {
			staticSystem.deadText="ロボットに捕まった。";
			Application.LoadLevel(4);
		}
	}
}
