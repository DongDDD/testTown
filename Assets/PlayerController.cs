using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    // Use this for initialization
    private Animator ani;
	void Start () {
        ani = GetComponent<Animator>();

		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.Q))
        {
            ani.SetBool("Attack1", true);
        }


		
	}
}
