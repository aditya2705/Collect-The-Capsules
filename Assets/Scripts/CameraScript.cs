using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {

	public Transform target;
	public int y_distance = -8;
	public float z_y_distance = 10f;
	bool flagFPS=false;
	float speed = 100.0f;

	// Update is called once per frame
	void Update () {

		if (Input.GetAxis("Mouse ScrollWheel") <0)
		{
			if (Camera.main.fieldOfView<=100)
				Camera.main.fieldOfView +=2;
		}
	
		if (Input.GetAxis("Mouse ScrollWheel") > 0)
		{
			if (Camera.main.fieldOfView>2)
				Camera.main.fieldOfView -=2;
		}


		if (!flagFPS) {
				transform.position = target.position + new Vector3 (0, z_y_distance, y_distance);
				transform.LookAt (target);
		} else {
				transform.position = target.position;
				Vector3 mouse = new Vector3(-Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X"), 0);
				transform.Rotate(mouse * Time.deltaTime * speed);
		}
		if (!flagFPS) {
			if (Input.GetMouseButtonDown (1)) {
						flagFPS = true;
						transform.rotation = Quaternion.identity;
						}
		} else {
			if (Input.GetMouseButtonDown (1)) {
					flagFPS = false;
						}
		}
	}
}
