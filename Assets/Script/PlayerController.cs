using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	private Rigidbody2D rb2d;
	private SpriteRenderer sr;
	private BoxCollider2D bc2d;


	private bool jump = false;
	[SerializeField]private float pwr = 1000f;

	void Start(){

		rb2d = gameObject.GetComponent<Rigidbody2D> ();
		sr = gameObject.GetComponent<SpriteRenderer> ();
		bc2d = gameObject.GetComponent<BoxCollider2D> ();
	}

	void Update() {


		if (Input.GetKeyDown("space") && !jump)
		{
			rb2d.AddForce(Vector2.up * pwr);
			jump = true;
		}

	}

	void OnCollisionEnter2D(Collision2D other)
	{
		jump = false;

		if (other.gameObject.tag == "Brick") {
			GameManager.Instance.gameStatus = GameStatus.GameOver;
		}
	}

}
