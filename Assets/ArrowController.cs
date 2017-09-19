using UnityEngine;
using System.Collections;

public class ArrowController : MonoBehaviour {

	GameObject player;
	// Use this for initialization
	void Start () {
		this.player = GameObject.Find ("player");
	}
	
	// Update is called once per frame
	void Update () {
		// フレームごとに等速で落下させる
		transform.Translate (0, -0.3f, 0);

		// 画面外に出たらオブジェクトを破棄する
		if (transform.position.y < -5.0f) {
			Destroy (gameObject);
			Debug.Log ("gameobject破棄");
		}

		// 当たり判定
		Vector2 p1 = transform.position;
		Vector2 p2 = this.player.transform.position;
		Vector2 dir = p1 - p2;
		float d = dir.magnitude;
		// 各オブジェクトの半径
		float r1 = 0.5f;
		float r2 = 1.0f;

		if (d < r1 + r2) {
			// 衝突した場合は矢を消す
			Destroy (gameObject);

			// GameDirectorスクリプトを取得しHPUIの減少処理を行う
			GameObject director = GameObject.Find ("GameDirector");
			director.GetComponent<GameDirector> ().DecreaseHp ();
		}
	}
}
