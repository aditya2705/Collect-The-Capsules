using UnityEngine;
using System.Collections;

public class BallScript : MonoBehaviour {

	int rotationSpeed1 = 150;
	int rotationSpeed2 = 150;
	public int jump;
	
	// Update is called once per frame
	void Update () {

		if (!TimeScript.gameStart)
				return;

		float rotation1 = Input.GetAxis ("Vertical") * rotationSpeed1;
		rotation1 *= Time.deltaTime;

		rigidbody.AddTorque (Vector3.right * rotation1);

		float rotation2 = Input.GetAxis ("Horizontal") * rotationSpeed2;
		rotation2 *= Time.deltaTime;
		
		rigidbody.AddTorque (Vector3.back * rotation2);



		if (Input.GetKeyDown(KeyCode.Escape)) 
			Application.Quit(); 

	}

	void OnTriggerEnter(Collider collider){
		if (collider.gameObject.tag == "Capsule") {
						if (!TimeScript.gameOver) {
								ScoreScript.AddPoint();
								audio.Play();
								collider.gameObject.SetActive (false);
						}
		}
	}

	void OnCollisionStay(Collision collision){
		if (collision.collider.gameObject.tag=="Plane") {
			if (Input.GetKeyDown (KeyCode.Space)&&rigidbody.velocity.y<=0.5) {
				Vector3 up = new Vector3(0,1,0);
				rigidbody.AddForce(up*jump);
			}
		}
	}

}
