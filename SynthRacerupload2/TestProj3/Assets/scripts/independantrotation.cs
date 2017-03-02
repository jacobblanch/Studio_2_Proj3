﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class independantrotation : MonoBehaviour {

    public static independantrotation Instance;


    public GameObject[] rotobjects;

    private float rotspeed = 0.1f;

    public Vector3 indrot;

    void Start ()
    {
        Instance = this;
	}
	



	void Update ()
    {

        rotateindividuals();
		
	}



    



    void rotateindividuals()
    {
        foreach (GameObject obj in rotobjects)
        {
            obj.transform.Rotate(indrot * Time.deltaTime * rotspeed);
        }
    }
}
