using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadomDestroy : MonoBehaviour {
	bool active = false;	//參數
	GameObject note;
	public int a;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
	if(active){
	float f = Random.Range(0.0f, 10.0f);
	if(f>a){
	Destroy(note);
	}
	active=false;
	}
		
	}
	void OnTriggerEnter(Collider col){
	if(col.gameObject.tag=="Note") //碰觸到Note標籤後消除
		{note=col.gameObject;
		active=true;}

	}
}
