using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectGameobject : MonoBehaviour {

    public static GameObject selectedGO;

    public void SelectGO(GameObject pressed) {
        selectedGO = pressed;
    }
}
