using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectThisHouse : MonoBehaviour {

    public GameObject currGO;

    public void MoveGameObject(GameObject newPos)
    {
         currGO.transform.position = newPos.transform.position;
    }

    public void Select(GameObject clickedGO)
    {
        currGO = clickedGO;
    }
}
