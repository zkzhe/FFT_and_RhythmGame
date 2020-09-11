using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class miss_true : MonoBehaviour {
	 

	public GameObject miss;
	void Awake () {
	
	}
	void Start () {
  

    }
	
	void Update () {
		
	}
	 
	
	void OnTriggerEnter(Collider col){
		 miss.SetActive(true);
	}
	
}
