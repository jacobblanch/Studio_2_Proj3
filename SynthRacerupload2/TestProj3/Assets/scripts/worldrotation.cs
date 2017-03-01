using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class worldrotation : MonoBehaviour {

    float initialdroppoint = 100;
    float ypos;

    bool canrotate = false;

    float spinspeed = 10;

	// Use this for initialization
	void Start ()
    {
        ypos = this.transform.position.y;
	}
	
	// Update is called once per frame
	void Update ()
    {

      if ( ypos >= initialdroppoint)
        {
            ypos -= Time.deltaTime * 30;
            canrotate = false;
        }

       else
        {
            canrotate = true;
        }

        if (canrotate)
        {
            Rotate();
        }

        transform.position = new Vector3(transform.position.x, ypos, transform.position.z);
		
	}


    void Rotate()
    {
        transform.Rotate(spinspeed /2 * Time.deltaTime, spinspeed * Time.deltaTime, 0);
    }


}
