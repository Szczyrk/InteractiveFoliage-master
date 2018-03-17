using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Setup2 : MonoBehaviour {


	public Camera cam;
    public Camera cam2;
    public Material mat;

	// Use this for initialization
	void Start () {
		Matrix4x4 vp = cam.projectionMatrix * cam.worldToCameraMatrix;
        Matrix4x4 vp2 = cam2.projectionMatrix * cam2.worldToCameraMatrix;

        mat.SetMatrix("_Matrix2", vp2);
        mat.SetMatrix("_Matrix", vp);
		mat.SetTexture("_PlayersTexture", cam.targetTexture);
        mat.SetTexture("_PlayersTexture2", cam2.targetTexture);
    }
	
	// Update is called once per frame
	void Update () {
	}
}
