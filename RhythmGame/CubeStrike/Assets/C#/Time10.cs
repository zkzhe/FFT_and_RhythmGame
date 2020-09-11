using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Time10 : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine(NowPlay());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    IEnumerator NowPlay()
    {
        for(float i=0;i<=5;i+=Time.deltaTime)
        {
            Debug.Log(i + "second");
            yield return 0;
        }
    }
}
