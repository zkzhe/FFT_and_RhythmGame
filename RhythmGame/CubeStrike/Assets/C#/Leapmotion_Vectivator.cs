using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Leapmotion_Vectivator : MonoBehaviour {
	 
	
	public KeyCode key;
	bool active = false;
	GameObject note,gm;
	public bool createMode;
	public GameObject n,z;
	
	void Awake () {
	
	}
	void Start () {
	gm = GameObject.Find("GameManager");
	

	}
	
	void FixedUpdate () {
	    if(createMode){
		if(Input.GetKeyDown(key))
		Instantiate(n,transform.position,Quaternion.identity);
					  }
		if(active){
		Destroy(note);
		Instantiate(z,transform.position,Quaternion.identity);
			
			gm.GetComponent<GameManager>().AddStreak();
			AddScore();
			active=false;
				  }   
				   }
	 void AddScore(){
	 PlayerPrefs.SetInt("Score",PlayerPrefs.GetInt("Score")+gm.GetComponent<GameManager>().GetScore());
	 }
	
	void OnTriggerEnter(Collider col){
	    
		
		
		if(col.gameObject.tag=="Note")
		note=col.gameObject;
		active=true;
	}
	void OnTriggerExit(Collider other){
	
	}
}
//Leapmotion_Vectivator1的範本