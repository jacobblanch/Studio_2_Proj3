using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scenechooser : MonoBehaviour {

    private int selector;


	void Start () {
        selector = PlayerPrefs.GetInt("MenuCHoice");

        if (selector == 1)
        {
            Drive();
        }

        if (selector == 2)
        {
            Cruise();
        }
	}
	
	void Drive()
    {

    }

    void Cruise()
    {

    }
}
