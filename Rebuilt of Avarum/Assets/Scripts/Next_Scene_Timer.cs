using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Next_Scene_Timer : MonoBehaviour {
    
	// Update is called once per frame
	void Update () {
        StartCoroutine(Wait());
	}

    IEnumerator Wait() {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("MainMenu");
    }

}
