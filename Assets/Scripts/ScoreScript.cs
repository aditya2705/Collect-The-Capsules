using UnityEngine;
using System.Collections;

public class ScoreScript : MonoBehaviour {
	static public bool scoreStop = false;
	static public int score = 0;
	public Transform target;
	public int capsuleCount;
	TextMesh text;


	static public void AddPoint(){
		++score;
	}
	static public void ScoreStop(){
		scoreStop = true;
	}
	static public void ResetScore(){
		score = 0;
		scoreStop = false;
	}

	void Start () {
		text = gameObject.GetComponent<TextMesh> ();
	}

	// Update is called once per frame
	void Update () {
		transform.position = target.position + new Vector3(0,1,0);
		if (score == capsuleCount) {
			score+=TimeScript.timeShort;
			scoreStop=true;
			TimeScript.gameOver=true;
		}

		if (scoreStop) {
			text.text = "Final Score: "+score.ToString();
			return;
		}
		text.text = score.ToString ();
	}
}
