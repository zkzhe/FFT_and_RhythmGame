using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP : MonoBehaviour {
	float rm;
	GameObject a;
	// Use this for initialization
	void Start () {
		a=transform.Find("a").gameObject;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		rm=PlayerPrefs.GetInt("HP");
		a.transform.localPosition = new Vector3((rm-12)/20,0,0);
	}
}
//HP位置顯示
