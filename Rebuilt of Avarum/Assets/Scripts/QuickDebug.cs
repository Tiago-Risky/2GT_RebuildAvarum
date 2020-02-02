using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuickDebug : MonoBehaviour {

    public Text txt;

    public void qdbg() {
        txt.text = "";
        foreach (KeyValuePair<GameObject, GameObject> kvp in PositionGO.positions) {
            txt.text += "Pos " + kvp.Key.name;
            txt.text += " // GO " + kvp.Value.name;
            txt.text += "\n";
        }

    }
}
