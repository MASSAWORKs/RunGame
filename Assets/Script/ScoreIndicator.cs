using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreIndicator : MonoBehaviour {

	[SerializeField]private Text _scoreText;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		_scoreText.text = GameManager.Instance.passedCount.ToString ();
	}
}
