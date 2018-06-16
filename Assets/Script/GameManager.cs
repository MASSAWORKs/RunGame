using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManager : SingletonMonoBehaviour<GameManager> {

	public Text _titleText;

	public Text _scoretext;


	public int passedCount;

	public float speed;


	public GameStatus gameStatus;


	void Start () {
		passedCount = 0;
		gameStatus = GameStatus.Title;

		speed = 5.5f;

		Time.timeScale = 1.5f;
	}

	void Update () {

		switch (gameStatus) {

		case GameStatus.Title:
			
			if(Input.GetKeyDown("space")){
				gameStatus = GameStatus.OnGame;
				_titleText.gameObject.SetActive (false);
				_scoretext.gameObject.SetActive (true);
			}
			break;

		case GameStatus.OnGame:
			
			transform.position += transform.right * speed * Time.deltaTime;
			break;

		case GameStatus.GameOver:
			this.GameOver ();
			gameStatus = GameStatus.Idle;
			break;

		}

	}

	public void GameOver(){
		StartCoroutine (Reset ());
	}

	IEnumerator Reset(){
		yield return new WaitForSeconds (3f);
		
		SceneManager.LoadScene ("Main");
		yield break;
	}

}
