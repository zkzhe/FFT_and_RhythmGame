using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : MonoBehaviour {
    public GameObject Plane1;
    public GameObject Plane2;
    public GameObject Plane3;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider col)
    {  

        if (col.gameObject.tag == "1to2")
        {
            Plane2.SetActive(true);
            Plane1.SetActive(false);
        }
        if (col.gameObject.tag == "1to3")
        {
            Plane3.SetActive(true);
            Plane1.SetActive(false);
        }
        if (col.gameObject.tag == "2to3")
        {
            Plane3.SetActive(true);
            Plane2.SetActive(false);
        }
        if (col.gameObject.tag == "2to1")
        {
            Plane1.SetActive(true);
            Plane2.SetActive(false);
        }
        if (col.gameObject.tag == "3to1")
        {
            Plane1.SetActive(true);
            Plane3.SetActive(false);
        }
        if (col.gameObject.tag == "3to2")
        {
            Plane2.SetActive(true);
            Plane3.SetActive(false);
        }


    }

}
