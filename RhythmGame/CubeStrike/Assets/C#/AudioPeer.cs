﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]
public class AudioPeer : MonoBehaviour {
    AudioSource _audioSource;
    public static float[] _freqBand = new float[6];
    public static float[] _samples = new float[1024];
	// Use this for initialization
	void Start () {
        _audioSource = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
        GetSpectrumAudioSource();
        MakeFrequencyBands();
	}
    void GetSpectrumAudioSource()
    {
        _audioSource.GetSpectrumData(_samples, 0, FFTWindow.Blackman);
    }
    void MakeFrequencyBands()
    {
        int count = 0;
        for (int i=0; i<6; i++)
        {
            float average = 0;
            int sampleCount = (int)Mathf.Pow(2, i) * 2;
            if (i == 5)
            {
                sampleCount += 2;

            }
            for(int j = 0;j < sampleCount; j++ ){
            average += _samples[count] * (count + 1);
            count++;
        }
        average /= count;
        _freqBand[i] = average * 10;
        }
    }
}
