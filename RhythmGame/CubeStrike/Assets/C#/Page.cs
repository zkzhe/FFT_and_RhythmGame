using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Page : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void LoadScene(int a){
	SceneManager.LoadScene(a);
	}
	public void Quit(){
		Application.Quit();
	}
}
//切換頁面