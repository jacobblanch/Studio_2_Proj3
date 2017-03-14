using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistortObject : BeatReceiver {

    Material mat;
    public float effectLength = 0.5f;
    public float objectSize = 1;
    float beatTimer;

    [Header("Distortion Effect")]
    public float distortStrength = 10;
    float distortSpeed = 0.1f;
    public int beatsBetweenDistort = 0;
    int distortBeatTimer = 0;
    float distortZone = 0.8f;
    bool distorting = false;

    [Header("Distortion Pulse")]
    public float pulseStrength = 2;
    public int beatsBetweenPulse = 1;
    int pulseBeatTimer = 0;
    bool pulsing = false;
    float pulseTimer;

	void Start () {
        mat = gameObject.GetComponent<Renderer>().material;
	}

	void Update () {
        distortZone += distortSpeed * Time.deltaTime;
        mat.SetFloat("_DistortZone", distortZone);

        if(distortZone > 0.9f)
        {
            distortZone = 0.8f;
        }

        if(distorting)
        {
            beatTimer -= Time.deltaTime;

            if (beatTimer <= 0)
            {
                distorting = false;
                mat.SetFloat("_Distorting", 0f);
            }
        }

        if (pulsing)
        {
            pulseTimer -= (effectLength * objectSize) * Time.deltaTime;
            mat.SetFloat("_PulseTime", Mathf.Cos(effectLength - pulseTimer));
            //print("TIME: " + Mathf.Cos(pulseTimer));

            if((effectLength - pulseTimer) >= Mathf.PI)
            {
                pulsing = false;
                pulseTimer = 0;
                mat.SetFloat("_PulseTime", 0);
                mat.SetFloat("_Pulsing", 0f);
            }
        }

        if (Input.GetKeyDown(KeyCode.O))
        {
            OnBeat();
        }
	}

    public override void OnBeat()
    {
        distortBeatTimer--;

        if (distortBeatTimer < 0)
        {
            beatTimer = effectLength;
            distorting = true;
            distortBeatTimer = beatsBetweenDistort;
            mat.SetFloat("_DistortStrength", distortStrength);
            mat.SetFloat("_Distorting", 1f);
        }

        pulseBeatTimer--;

        if(pulseBeatTimer < 0)
        {
            pulseTimer = effectLength;
            pulsing = true;
            pulseBeatTimer = beatsBetweenPulse;
            mat.SetFloat("_PulseStrength", pulseStrength);
            mat.SetFloat("_Pulsing", 1f);
        }

        base.OnBeat();
    }
}
