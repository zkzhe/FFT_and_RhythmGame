using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PPtext : MonoBehaviour {
	public string name;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Text>().text=PlayerPrefs.GetInt(name)+"";
	}
}
//利用name取得"text"內容