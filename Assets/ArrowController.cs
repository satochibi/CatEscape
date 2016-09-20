using UnityEngine;
using System.Collections;

public class ArrowController : MonoBehaviour {

	GameObject player;

	// Use this for initialization
	void Start () {
		this.player = GameObject.Find("player");
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Translate(0, -0.1f, 0);

		//矢の画面外
		if (this.transform.position.y < -5.0f)
		{
			Destroy(gameObject);
		}

		Vector2 p1 = this.transform.position;
		Vector2 p2 = this.player.transform.position;
		Vector2 dir = p1 - p2;
		float d = dir.magnitude;
		float r1 = 0.5f;
		float r2 = 1.0f;

		//衝突判定
		if (d < r1 + r2)
		{
			Destroy(gameObject);

			GameObject director = GameObject.Find("GameDirector");
			director.GetComponent<GameDirector>().DecreaseHP();
		}

	}
}
