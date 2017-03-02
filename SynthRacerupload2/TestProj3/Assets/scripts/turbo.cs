using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turbo : MonoBehaviour {

    public GameObject turbopoint;

    void Start ()
    {
		
	}
	
	void Update ()
    {
		if (Input.GetKeyDown(KeyCode.Escape))
        {
            TURBO();
        }
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            NomoreTURBO();
        }
    }


    void TURBO()
    {

    }

    void NomoreTURBO()
    {

    }
}
