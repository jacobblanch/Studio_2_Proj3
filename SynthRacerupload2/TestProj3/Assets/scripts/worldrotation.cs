using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class worldrotation : MonoBehaviour {

    public static worldrotation Instance;


    public GameObject floor;

    private float initialdroppoint = -400;
    private float floorypos;

    private bool canrotate = false;


    public Vector3 worldrot;


    private float spinspeed = 7f;




	void Start ()
    {
        Instance = this;
        floorypos = floor.transform.position.y;
	}
	



	void Update ()
    {

      if (floorypos >= initialdroppoint)
        {
            floorypos -= Time.deltaTime * 30;
            canrotate = false;
            floor.transform.position = new Vector3(transform.position.x, floorypos, transform.position.z);
        }

       else
        {
            canrotate = true;
            Rotate();
        }

        if (canrotate)
        {
            
        }

       
		
	}

    void Rotate()
    {
        floor.transform.RotateAround(this.transform.position, worldrot,  spinspeed * Time.deltaTime);
    }


}
