using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.tag == "Destroyer") {
			Destroy (this.gameObject);
		}

		if(col.tag == "Counter"){
			GameManager.Instance.passedCount++;
			Debug.Log (GameManager.Instance.passedCount);
		}
	}

}
