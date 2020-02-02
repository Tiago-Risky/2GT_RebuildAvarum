using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionGO : MonoBehaviour {

    public static Dictionary<GameObject, GameObject> positions = new Dictionary<GameObject, GameObject>();

    public void positionObject(GameObject pressed) {
        if(SelectGameobject.selectedGO!=null){
            if (positions.ContainsKey(pressed))
            {
                positions[pressed] = SelectGameobject.selectedGO;
            }
            else
            {
                positions.Add(pressed, SelectGameobject.selectedGO);
            }
        }
    }
}
