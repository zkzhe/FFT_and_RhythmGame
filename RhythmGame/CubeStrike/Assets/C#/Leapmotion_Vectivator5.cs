using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Leapmotion_Vectivator5 : MonoBehaviour {
	 
	
	public KeyCode key;		//選擇按鍵	
	bool active = false;	//參數
	bool aaa = false;	//參數
	bool bbb = false;	//參數
	GameObject note,gm,a,b,c; //參考物件
	public bool createMode;	//創造模式
	public GameObject n,z; //創造n方塊 創造z粒子系統
	
	void Awake () {
	
	}
	void Start () {
	gm = GameObject.Find("GameManager5");	//抓取GameObject內的函數
	

	}
	
	void FixedUpdate () {
	    if(createMode){		//此區的創造方塊
		if(Input.GetKeyDown(key))
		Instantiate(n,transform.position,Quaternion.identity);	//創造n方塊
					  }
		
		if(aaa){	//消除"Cubea 1"
		Destroy(a);
		Instantiate(z,transform.position,Quaternion.identity);	//創造z粒子系統
			
			gm.GetComponent<GameManager5>().AddStreak();		//抓取GameManager物件內的函數使用AddStreak()
			AddScore();
			aaa=false;
				  }   

		if(active){
		Destroy(note);
		Instantiate(z,transform.position,Quaternion.identity);		//創造z粒子系統
			 
			gm.GetComponent<GameManager5>().AddStreak();		//抓取GameManager物件內的函數使用AddStreak()
			AddScore();
			active=false;
				  }   
				   }
	 void AddScore(){
	 PlayerPrefs.SetInt("Score5",PlayerPrefs.GetInt("Score5")+gm.GetComponent<GameManager5>().GetScore());	//抓取Score.text後再讀取分數再用GameManager的函數加分
	 }
	
	void OnTriggerEnter(Collider col){
	    
		if(col.gameObject.tag=="Finish")	//此標籤在"Cubea 1"上
		{
		a=col.gameObject;
		b=a.transform.GetChild(6).gameObject;	//抓取此標籤在"Cubea 1"上的子類別第7個
		b.SetActive(false);	//子類別第7個隱藏
		}
		if(col.gameObject.tag=="Player")	//Cubeaaa的標籤
		{
		b.SetActive(true);
		}
	
		if(col.gameObject.tag=="Respawn")	//Cubebbb的標籤
		{
		aaa=true;
		}
		if(col.gameObject.tag=="Note") //碰觸到Note標籤後消除
		{note=col.gameObject;
		active=true;}
        if (col.gameObject.tag == "GG")
        {
            gm.GetComponent<GameManager5>().RestStreak();
            note = col.gameObject;
            Destroy(note);
        }
        if (col.gameObject.tag == "X")
        {
            gm.GetComponent<GameManager5>().RestStreak();
            note = col.gameObject;
            Destroy(note);
        }
    }
	void OnTriggerExit(Collider other){
	
		
	}
}
