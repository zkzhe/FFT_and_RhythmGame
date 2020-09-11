using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane1 : MonoBehaviour {
    public GameObject p1;
    public GameObject p2;
    public GameObject p3;
    public GameObject p4;
    public GameObject p5;
    public GameObject p6;
    public GameObject p7;
    public GameObject p8;
  

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Level1()
    {
        p1.SetActive(true);
        p2.SetActive(false);
        p3.SetActive(false);
        p4.SetActive(false);
        p5.SetActive(false);
        p6.SetActive(false);
        p7.SetActive(false);
        p8.SetActive(false);
        
    }
    public void Level2()
    {
        p2.SetActive(true);
        p1.SetActive(false);
        p3.SetActive(false);
        p4.SetActive(false);
        p5.SetActive(false);
        p6.SetActive(false);
        p7.SetActive(false);
        p8.SetActive(false);

    }
    public void Level3()
    {
        p3.SetActive(true);
        p2.SetActive(false);
        p1.SetActive(false);
        p4.SetActive(false);
        p5.SetActive(false);
        p6.SetActive(false);
        p7.SetActive(false);
        p8.SetActive(false);

    }
    public void Level4()
    {
        p4.SetActive(true);
        p2.SetActive(false);
        p3.SetActive(false);
        p1.SetActive(false);
        p5.SetActive(false);
        p6.SetActive(false);
        p7.SetActive(false);
        p8.SetActive(false);

    }
    public void Level5()
    {
        p5.SetActive(true);
        p2.SetActive(false);
        p3.SetActive(false);
        p4.SetActive(false);
        p1.SetActive(false);
        p6.SetActive(false);
        p7.SetActive(false);
        p8.SetActive(false);

    }
    public void Level6()
    {
        p6.SetActive(true);
        p2.SetActive(false);
        p3.SetActive(false);
        p4.SetActive(false);
        p5.SetActive(false);
        p1.SetActive(false);
        p7.SetActive(false);
        p8.SetActive(false);

    }
    public void Level7()
    {
        p7.SetActive(true);
        p2.SetActive(false);
        p3.SetActive(false);
        p4.SetActive(false);
        p5.SetActive(false);
        p6.SetActive(false);
        p1.SetActive(false);
        p8.SetActive(false);

    }
    public void Level8()
    {
        p8.SetActive(true);
        p2.SetActive(false);
        p3.SetActive(false);
        p4.SetActive(false);
        p5.SetActive(false);
        p6.SetActive(false);
        p7.SetActive(false);
        p1.SetActive(false);

    }

    void OnTriggerEnter(Collider col)
    {  

        


    }

}
