using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			transform.Translate (-3, 0, 0);
		}

		if (Input.GetKeyDown (KeyCode.RightArrow)) {
			transform.Translate (3, 0, 0);
		}
	}

	//UIButton(R)のタップに対する処理
	public void RButtonDown () {
		transform.Translate (3, 0, 0);
	}

	//UIButton(L)のタップに対する処理
	public void LButtonDown () {
		transform.Translate (-3, 0, 0);
	}
}
