using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roadbordercontroller : MonoBehaviour {

    public GameObject player;

    private float PDist;

    private float disttorise = 70;

    private float wheretodropto = -50;

    private float RiseRate = 1f;

    private Vector3 bottom;
    private Vector3 top;

    private bool toldtofall;
    private bool toldtorise;

    void Start ()
    {
        bottom = new Vector3(transform.position.x, wheretodropto, transform.position.z);
        top = new Vector3(transform.position.x, 0.5f, transform.position.z);

    }


    void Update ()
    {
		PDist = Vector3.Distance(player.transform.position, transform.position);


        if (PDist >= disttorise)
        {
            Fall();
            toldtofall = true;
            toldtorise = false;
        }

        if (PDist <= disttorise)
        {
            Rise();
            toldtorise = true;
            toldtofall = false;
        }
    }




    void Rise()
    {
        if (!toldtorise)
        {
            StopAllCoroutines();
            StartCoroutine("platformrise");
        }
       
    }




    void Fall()
    {
        if (!toldtofall)
        {
        StopAllCoroutines();
        StartCoroutine("platformfall");
        }
    }



    IEnumerator platformrise()
    {
        
        if (transform.position.y >= wheretodropto)
        {
            this.transform.position = Vector3.Lerp(top, bottom, RiseRate * Time.deltaTime);
        }
        yield return null;
    }

    IEnumerator platformfall()
    {
        if (transform.position.y <= 0.5)
        {
            this.transform.position = Vector3.Lerp(bottom, top, RiseRate * Time.deltaTime);

        }
        yield return null;
    }
}
