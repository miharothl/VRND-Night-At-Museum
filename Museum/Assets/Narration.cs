using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Narration : MonoBehaviour {


    public GameObject other;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    public void StartNarration()
    {
        Debug.Log("StartNarratioin was called!");

        GvrAudioSource audio = GetComponent<GvrAudioSource>();

        var comps = GetComponentsInChildren<GvrAudioSource>();

        comps[0].Play();
        comps[0].volume = 1.0f;

        var otherAudio = other.GetComponentsInChildren<GvrAudioSource>();
        otherAudio[0].volume = 0.1f;
    }

    public void TuneInToVideo()
    {
        Debug.Log("TuneItToVideo was called!");

        var comps = GetComponentsInChildren<GvrAudioSource>();

        comps[0].volume = 1.0f;

        var otherAudio = other.GetComponentsInChildren<GvrAudioSource>();
        otherAudio[0].volume = 0.1f;
    }
}
