using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music1 : MonoBehaviour {
	bool called=true;
    public AudioSource music;

    void Start()
    {
        music = GetComponent<AudioSource>();
   
    }


    void FixedUpdate () {
		if(PlayerPrefs.GetInt("Playmusic") ==1 )
            music.Play();
        PlayerPrefs.SetInt("Playmusic", 0);

    }
}
//設定參數後讓音樂撥放