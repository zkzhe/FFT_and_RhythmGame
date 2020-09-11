using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Rigidbody_velocity : MonoBehaviour {
		public float speed;
        private Rigidbody rb;
		bool called=false;
        void Start () {
                rb = GetComponent<Rigidbody> ();
        }
        void FixedUpdate () {
               if(PlayerPrefs.GetInt("Start")==1)
                        rb.velocity =new Vector3(0, 0, -1) * speed;
				
                
        }
}
//設定參數後讓音樂物體移動同步  