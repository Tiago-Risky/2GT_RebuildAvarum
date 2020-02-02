using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnColl : MonoBehaviour {
	public GameObject Jarra;
	public GameObject JarraTotal;
	public GameObject AudioBoing;
	private int counter;
	// Use this for initialization
	void OnTriggerEnter (Collider other) {

		if (other.gameObject.tag == ("Jarra")) {
			Debug.Log ("Entra");
			StartCoroutine (Move ());
			StartCoroutine (SoundPlay ());

		}
		
	}


	IEnumerator Move() {



			Jarra.GetComponent<Animation> ().Play ("novoJarraPinchar");
			yield return new WaitForSeconds (0.35f);
			JarraTotal.GetComponent<Rigidbody> ().AddForce (0,250,0);
	
	

		
	}

	IEnumerator SoundPlay() {



		yield return new WaitForSeconds (0.6f);
		AudioBoing.GetComponent<AudioSource> ().Play ();



	}



	IEnumerator Move3() {


		while (true) {
			yield return new WaitForSeconds (2.5f);
			JarraTotal.transform.eulerAngles += new Vector3 (0, 180f, 0);
		}
	}
	void Start(){
		counter = 1;
	
		StartCoroutine (Move3());
	    
	
	}
	void Update () {
		
		JarraTotal.transform.Translate (Vector3.forward * 8f * Time.deltaTime);


		/*	if (Jarra.transform.localScale.y <= 2.55f) {
			transform.Translate (Vector3.down * 20f * Time.deltaTime);

		}else if (Jarra.transform.localScale.y >= 3.5f) {
			
			transform.Translate (Vector3.up * 35.4f * Time.deltaTime);
		}*/







	}

}
