using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDown : MonoBehaviour {
	public GameObject JARRA ;
	void OnTriggerEnter () {
		
		JARRA.transform.Translate (Vector3.up * 20f * Time.deltaTime);
	}
}
