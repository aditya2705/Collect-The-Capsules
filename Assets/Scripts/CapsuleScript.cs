using UnityEngine;
using System.Collections;

public class CapsuleScript : MonoBehaviour {

	float xMax = 11f;
	float xMin = -11f;
	float zMax = 11f;
	float zMin = -11f;
	float yMin = 1.3f;
	float yMax = 2.82f;


	// Use this for initialization
	void Start () {

		GameObject[] capsules = GameObject.FindGameObjectsWithTag ("Capsule");
		foreach (GameObject capsule in capsules) {
			Vector3 pos = capsule.transform.position;
			pos.z = Random.Range(zMin,zMax);
			pos.y = Random.Range(yMin,yMax);
			pos.x = Random.Range(xMin,xMax);
			capsule.transform.position = pos;
		}
	
	}
}
