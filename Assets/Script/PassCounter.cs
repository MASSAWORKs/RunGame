using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassCounter : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnColliderEnter2D(Collision2D other)
	{

		if (other.gameObject.tag == "Brick") {
			GameManager.Instance.passedCount++;
			Debug.Log ("yes");

		}
	}
}
