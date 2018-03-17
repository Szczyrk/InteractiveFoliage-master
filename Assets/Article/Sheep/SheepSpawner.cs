using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheepSpawner : MonoBehaviour {

	public GameObject animal;

	public float minTime = 1f;
	public float maxTime = 3f;

	private float t = 0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		t -= Time.deltaTime;
		if (t <= 0) {
			t = Random.value * (maxTime - minTime) + minTime;
			var instance = Instantiate(animal);
			instance.transform.position = this.transform.position;
		}
	}
}
