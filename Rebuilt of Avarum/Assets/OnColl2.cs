using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnColl2 : MonoBehaviour {

	void OnTriggerStay (Collider other) {
		if (other.gameObject.tag == ("Jarra")) {
			Debug.Log ("Entra2");
			other.gameObject.GetComponent<Rigidbody> ().AddForce (100,0,0);

		}

	}
}
