using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotationmanager : MonoBehaviour {


    private Quaternion _indrotation;

    private Quaternion _worldrotation;

    private float indchangetimer;
    private float indchangebuffer = 10;

    private float Wchangetimer;
    private float Wchangebuffer = 25;

	void Start ()
    {
        Changeindrot();

        Changeworldrot();

        indchangetimer = indchangebuffer;
        Wchangetimer = Wchangebuffer;

    }
	
	void Update ()
    {
        indchangetimer -= Time.deltaTime;
        Wchangetimer -= Time.deltaTime;


        if (indchangetimer <= 0)
        {
            Changeindrot();
            indchangetimer = indchangebuffer;
        }

        if (Wchangetimer <= 0)
        {
            Changeworldrot();
            Wchangetimer = Wchangebuffer;
        }
    }


    void Changeindrot()
    {
        _indrotation = Random.rotation;
        Debug.Log(_indrotation);
        independantrotation.Instance.indrot = _indrotation.eulerAngles;
    }


    void Changeworldrot()
    {
       
        _worldrotation = Random.rotation;
        Debug.Log(_worldrotation);
        worldrotation.Instance.worldrot = _worldrotation.eulerAngles;

    }
}
