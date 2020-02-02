using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerUp : MonoBehaviour {
	
	public GameObject JARRA ;
	void OnTriggerEnter () {
		
		JARRA.transform.Translate (Vector3.down * 20f * Time.deltaTime);
	}
	


}
