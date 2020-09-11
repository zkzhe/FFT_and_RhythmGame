using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class add0 : MonoBehaviour
{   bool qqq = false;//參數
    public GameObject aa,bb;
    
    GameObject gm;

    public GameObject z; //創造n方塊 創造z粒子系統

    void Awake()
    {

    }
    void Start()
    {
        gm = GameObject.Find("GameManager1");
   



    }

    void FixedUpdate()
    {
        aa.transform.position += new Vector3(0, -0.00008f, 0);




        if (qqq )
        {
            Instantiate(z, bb.transform.position, Quaternion.identity);    //創造z粒子系統
            


            gm.GetComponent<GameManager1>().ap = true;
            qqq = false;

        }

      
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "add")
        {
            if (gm.GetComponent<GameManager1>().ppp)
            {
                aa.transform.position += new Vector3(0, 0.025f, 0);
                qqq = true;
                gm.GetComponent<GameManager1>().ppp = false;
              



            }
               
        }
    }

}
