using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sheep : MonoBehaviour {

	public float speed = 1f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.position += new Vector3(0, 0, speed * Time.deltaTime);

		if (this.transform.position.z > 5f) {
			Destroy(gameObject);
		}
	}
}
