using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class GameManager1 : MonoBehaviour {
	int multiplier=1;	//分數加乘值
	int	streak=0;	//連擊		
	public GameObject miss_true;    //miss字幕
    GameObject note;
    public bool ppp = true;
    public bool ap = false;


    // Use this for initialization
    void Start () {
		PlayerPrefs.SetInt("Score1",0);
		PlayerPrefs.SetInt("Streak",0);
		PlayerPrefs.SetInt("Mult",1);
		PlayerPrefs.SetInt("HP",22);
        PlayerPrefs.SetInt("Start", 0);
        PlayerPrefs.SetInt("Playmusic", 0);          //設置參數訪值音樂延遲--->Music(C#)	

        StartCoroutine(NowPlay()); //倒數
    
    }
	
	// Update is called once per frame
	public void Update () {
        if (ap)
        {
            Invoke("ppp1",0.35f);
            ap = false;
        }
	}
    IEnumerator NowPlay()
    {
        for (float i = 0; i <= 5; i += Time.deltaTime)
        {
            Debug.Log(i + "second");
            yield return 0;
        }
        PlayerPrefs.SetInt("Start", 1);
        PlayerPrefs.SetInt("Playmusic", 1);
    }
 
    public int GetScore(){	//獲得分數
		return 100*multiplier;
	}
	public void AddStreak(){	//連擊加成參數設定
		if(PlayerPrefs.GetInt("HP")+2<22)
		PlayerPrefs.SetInt("HP",PlayerPrefs.GetInt("HP")+2);
		streak++;
		if(streak>=24)
		multiplier=4;
		else if(streak>=16)
		multiplier=3;
		else if(streak>=8)
		multiplier=2;
		else
		multiplier=1;
		UpdateGUI();
	}
	public void RestStreak(){	//連擊加成參數設定
		 PlayerPrefs.SetInt("HP",PlayerPrefs.GetInt("HP")-1);
		 if(PlayerPrefs.GetInt("HP")<0)
		 Lose();
		 streak=0;
		 multiplier=1;
		 UpdateGUI();
	}
	void UpdateGUI(){	//更新GUI
		PlayerPrefs.SetInt("Streak",streak);
		PlayerPrefs.SetInt("Mult",multiplier);

	}
    public void ppp1()
    {
     ppp = true;
    }
    void Lose(){	//遊戲中Lose的函數
	PlayerPrefs.SetInt("Start",0);
	SceneManager.LoadScene(5);
		
	}
	public void Win(){	//遊戲中Win的函數
	if(PlayerPrefs.GetInt("HighScore1")<PlayerPrefs.GetInt("Score1"))
	PlayerPrefs.SetInt("HighScore1",PlayerPrefs.GetInt("Score1"));
	PlayerPrefs.SetInt("Start",0);
	SceneManager.LoadScene(5);
	}
	void OnTriggerEnter(Collider col){	//觸發函數
  
            miss_true.SetActive(false);		//miss字幕隱藏

	if(col.gameObject.tag=="Win")	//碰觸到Win標籤
		GetComponent<GameManager1>().Win();  //獲得GameManager內的Win函數
        if (col.gameObject.tag == "Note")
        {
            RestStreak();
            note = col.gameObject;
            Destroy(note);
        }
        if (col.gameObject.tag == "Finish")
        {
            RestStreak();
            note = col.gameObject;
            Destroy(note);
        }
     
    }


}
