using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turbo : MonoBehaviour {

    public GameObject turbopoint;
    public GameObject warpeffects;
    public GameObject leftbraketrail;
    public GameObject rightbraketrail;

    void Start ()
    {
		
	}
	
	void Update ()
    {
		if (Input.GetKeyDown(KeyCode.Q))
        {
            TURBO();
        }
        if (Input.GetKeyUp(KeyCode.Q))
        {
            NomoreTURBO();
        }
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }


    void TURBO()
    {
        rightbraketrail.SetActive(true);
        leftbraketrail.SetActive(true);
        warpeffects.SetActive(true);
    }

    void NomoreTURBO()
    {
        rightbraketrail.SetActive(false);
        leftbraketrail.SetActive(false);
        warpeffects.SetActive(false);
    }
}
