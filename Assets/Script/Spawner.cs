using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	[SerializeField]
	private GameObject _brick;

	private Vector3 _lastPos;

	void Start () {
		_lastPos = RoundVec(this.transform.position);

		this.SpawnBrick ();
	}
	
	void Update () {
		if(this.transform.position.x - _lastPos.x > 7f){
			this.SpawnBrick ();
		}
	}

	void SpawnBrick(){
		_lastPos = RoundVec(this.transform.position);

		var numY = Random.Range (0,2);

		Instantiate(_brick, new Vector3(_lastPos.x, numY, 0) , Quaternion.identity);
		Debug.Log ("Spawned : " + _lastPos);
	}


	Vector3 RoundVec(Vector3 presentVec){
		Vector3 lastVec;

		lastVec = new Vector3( Mathf.Round (presentVec.x), Mathf.Round (presentVec.y), 0f);

		return lastVec;
	}
}
