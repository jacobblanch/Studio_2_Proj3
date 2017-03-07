using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turbo : MonoBehaviour {

    public GameObject turbopoint;
   // public GameObject warpeffects;
    public GameObject leftbraketrail;
    public GameObject rightbraketrail;

    public GameObject cameraMain;

    private float Colourshiftvalue;
    private float GLitchIntensity;

    private bool TURBOBOOL;

    void Start ()
    {
        rightbraketrail.SetActive(false);
        leftbraketrail.SetActive(false);
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



        if (TURBOBOOL)
        {
            if (cameraMain.GetComponent<UnityStandardAssets.ImageEffects.BloomOptimized>().intensity <= 1.2f)
            {
                cameraMain.GetComponent<UnityStandardAssets.ImageEffects.BloomOptimized>().intensity += 0.1f;
            }


            if (cameraMain.GetComponent< RetroAesthetics.RetroCameraEffect>().chromaticAberration <= 17)
            {
                cameraMain.GetComponent<RetroAesthetics.RetroCameraEffect>().chromaticAberration += 2;
            }
        }

        else
        {
            if (cameraMain.GetComponent<UnityStandardAssets.ImageEffects.BloomOptimized>().intensity >= 0.5f)
            {
                cameraMain.GetComponent<UnityStandardAssets.ImageEffects.BloomOptimized>().intensity -= 0.1f;
            }


            if (cameraMain.GetComponent<RetroAesthetics.RetroCameraEffect>().chromaticAberration >= 5)
            {
                cameraMain.GetComponent<RetroAesthetics.RetroCameraEffect>().chromaticAberration -= 2;
            }
        }
    }


    void TURBO()
    {
        rightbraketrail.SetActive(true);
        leftbraketrail.SetActive(true);
        //  warpeffects.SetActive(true);
        TURBOBOOL = true;
        
    }

    void NomoreTURBO()
    {
        TURBOBOOL = false;
        rightbraketrail.SetActive(false);
        leftbraketrail.SetActive(false);
      //  warpeffects.SetActive(false);
      //  cameraMain.GetComponent<UnityStandardAssets.ImageEffects.BloomOptimized>().intensity = 0.5f;
      //  cameraMain.GetComponent<RetroAesthetics.RetroCameraEffect>().chromaticAberration = 5;
    }
}
