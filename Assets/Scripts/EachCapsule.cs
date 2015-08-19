using UnityEngine;
using System.Collections;

public class EachCapsule : MonoBehaviour {

	// Use this for initialization
	void Start () {
		transform.rotation = Quaternion.Euler (Random.Range(30,330), Random.Range(30,330), Random.Range(30,330));
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (Vector3.right);
	}

}
