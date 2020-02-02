using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dondestroy2 : MonoBehaviour {

	private static Dondestroy2 _instance;
	public static int cn = 0;
	// Use this for initialization
	void Awake () {
		
		if(!_instance)

			_instance = this ;

		else

			Destroy(this.gameObject);



	

		DontDestroyOnLoad (this.gameObject);


	}
	void Update(){
	
		if ((SceneManager.GetActiveScene ().name == ("ARPrototipo") ||
			SceneManager.GetActiveScene ().name == ("JarraEPedras") ||
			SceneManager.GetActiveScene ().name == ("MiniGame")) && (cn == 1)) 
		{
			cn = 2;
			this.gameObject.GetComponent<AudioSource> ().Play ();
			Debug.Log (cn);

		}

		if (SceneManager.GetActiveScene ().name == ("mid_Scene_1")||
			SceneManager.GetActiveScene ().name == ("Tutorial_1")) 
		{
			cn = 1;
			this.gameObject.GetComponent<AudioSource> ().Stop ();


		}
	
	}


}
