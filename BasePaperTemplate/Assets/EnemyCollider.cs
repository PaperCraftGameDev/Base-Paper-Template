using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollider : MonoBehaviour {

    BoxCollider collider;

	// Use this for initialization
	void Start () {
        collider = gameObject.GetComponent<BoxCollider>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider collider)
    {
        //Start Battle transition animation

        //Save Info to BattleParameters

        //Load battle scene
    }
}
