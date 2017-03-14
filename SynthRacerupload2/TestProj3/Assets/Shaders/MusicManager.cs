using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MusicManager : MonoBehaviour {

    public AudioSource audioSource;
    float[] spectrum = new float[64];

    public List<GameObject> receivers = new List<GameObject>();
    List<BeatReceiver> recs = new List<BeatReceiver>();

	void Start ()
    {
        if (receivers.Count > 0)
        {
            for (int i = 0; i < receivers.Count; i++)
            {
                recs.Add(receivers[i].GetComponent<BeatReceiver>());
            }
        }
	}
	
	void Update ()
    {
        audioSource.GetSpectrumData(spectrum, 0, FFTWindow.Rectangular);

        if(spectrum[0] > 0.5f)
        {
            SendBeat();
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            SendBeat();   
        }
	}

    void SendBeat()
    {
        for (int i = 0; i < recs.Count; i++)
        {
            recs[i].OnBeat();
        }
    }
}
