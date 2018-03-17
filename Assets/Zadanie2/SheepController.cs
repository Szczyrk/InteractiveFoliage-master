using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheepController : MonoBehaviour {


	public float speed = 3f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float dx = Input.GetAxis("Horizontal") * Time.deltaTime * speed; 
		float dz = Input.GetAxis("Vertical") * Time.deltaTime * speed;

		if (dx != 0 || dz != 0) {
			Vector3 newPosition = transform.position + new Vector3(dx, 0, dz);
			if (newPosition.x < 10f && newPosition.x > -10f && newPosition.z < 10f && newPosition.z > -10f) {
				transform.position = newPosition;
			}
			transform.rotation = Quaternion.LookRotation(new Vector3(dx, 0, dz).normalized);
			GetComponent<Animator>().SetBool("Run", true);
		}
		else {
			GetComponent<Animator>().SetBool("Run", false);
		}
	}
}
