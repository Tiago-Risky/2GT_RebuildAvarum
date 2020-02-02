using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textupandgone : MonoBehaviour {

        public GameObject objectToActivate;

        public void Start()
        {
           // objectToActivate.SetActive(false);
            StartCoroutine(ActivationRoutine());
        }


        IEnumerator ActivationRoutine()
        {
                  objectToActivate.SetActive(false);
                yield return new WaitForSeconds(4);
                 objectToActivate.SetActive(true);

                //Turn the Game Oject back off after 1 sec.
                //yield return new WaitForSeconds(1);

                //Game object will turn off
                //objectToActivate.SetActive(false);
        }
}

