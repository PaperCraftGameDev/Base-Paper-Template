using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject mainCharacter;
    private Vector3 offset;

	// Use this for initialization
	void Start () {
        offset = this.transform.position - mainCharacter.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.position = mainCharacter.transform.position + offset;
	}
}
