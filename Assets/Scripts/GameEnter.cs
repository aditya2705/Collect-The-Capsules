using UnityEngine;
using System.Collections;

public class GameEnter : MonoBehaviour {

	bool gamePlay = true;
	TextMesh text;
	// Use this for initialization
	void Start () {
		text = gameObject.GetComponent<TextMesh> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (!TimeScript.gameStart)
						gamePlay = true;
				else
						gamePlay = false;

		if (gamePlay) {
			text.text = "Left Click to Play\nScroll to Zoom\nSpace To Jump";
			if(Input.GetMouseButtonDown(0)){
				text.text="";
				gamePlay=false;
			}
		}
	}
}

