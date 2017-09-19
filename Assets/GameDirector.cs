using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour {

	GameObject hpGage;
	// Use this for initialization
	void Start () {
		this.hpGage = GameObject.Find ("HpGage");
	}
	
	// Update is called once per frame
	public void DecreaseHp () {
		// hpゲージの減少
		this.hpGage.GetComponent<Image> ().fillAmount -= 0.1f;
	}
}
