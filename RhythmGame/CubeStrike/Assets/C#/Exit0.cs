using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit0 : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    public void Update()
    {

    }
    public void abc()
    {
        SceneManager.LoadScene(0);
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "XX")
        {
            abc();
        }
    }
}
