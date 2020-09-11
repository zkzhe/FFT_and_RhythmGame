using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vectivator : MonoBehaviour {	//鍵盤消除函數
	 
	
	public KeyCode key;		//選擇按鍵
	bool active = false;	//參數
	GameObject note,gm;    //參考
	public bool createMode;		//創造模式
	public GameObject n;	//此區的創造方塊
	public GameObject miss_true;	//miss字幕
	void Awake () {
	
	}
	void Start () {
	
	

	}
	
	void FixedUpdate () {
	    if(createMode){		//創造模式
		if(Input.GetKeyDown(key))
		Instantiate(n,transform.position,Quaternion.identity);	//此區的創造方塊
	 }
		if(Input.GetKeyDown(key)&&active){	//消除
			Destroy(note);
			gm.GetComponent<GameManager>().AddStreak();	//抓取GameManager物件內的函數使用AddStreak()
			AddScore();
			active=false;	//false後以免連續加分
	 }   else if (Input.GetKeyDown(key)&&!active)	//亂按扣分
		gm.GetComponent<GameManager>().RestStreak();
		
	}
	 void AddScore(){
	 PlayerPrefs.SetInt("Score",PlayerPrefs.GetInt("Score")+gm.GetComponent<GameManager>().GetScore());		//抓取Score.text後再讀取分數再用GameManager的函數加分
	 }
	
	void OnTriggerEnter(Collider col){	//觸發函數
	    miss_true.SetActive(false);		//miss字幕隱藏
		if(col.gameObject.tag=="Win")	//碰觸到Win標籤
		gm.GetComponent<GameManager>().Win();	//獲得GameManager內的Win函數
		
		if(col.gameObject.tag=="Note")	//碰觸到Note標籤後的函數
		note=col.gameObject;
		active=true;
	}
	void OnTriggerExit(Collider other){
		
		
		
	}
}
