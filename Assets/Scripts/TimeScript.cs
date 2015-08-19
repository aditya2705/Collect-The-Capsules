using UnityEngine;
using System.Collections;

public class TimeScript : MonoBehaviour {
	public static bool gameOver = false;
	public static int timeShort;
	public int timeConst;
	float levelTimer=0.0f;
	TextMesh text;
	string TimeText=null;

	public static bool gameStart = false;
	// Use this for initialization
	void Start () {
		text = gameObject.GetComponent<TextMesh> ();
		levelTimer=0.0f;
		gameOver = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)){
			gameStart=true;
		}

		if (!gameStart)
			return;

		if (gameOver) {
			if(Input.GetMouseButtonDown(0)){
				Application.LoadLevel(Application.loadedLevel);
				ScoreScript.ResetScore();
			}	
			return;
		}
				

		levelTimer += Time.deltaTime;
		timeShort = timeConst-(int)(levelTimer);
		TimeText = "Time Left:" + timeShort.ToString()+"s";
		text.text = TimeText.ToString();
		if (timeShort == 0) {
			gameOver = true;
			TimeText = "Time Up!";
			text.text = TimeText.ToString();
			ScoreScript.ScoreStop();
		}
	}
}
