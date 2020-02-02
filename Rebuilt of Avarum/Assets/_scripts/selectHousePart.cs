using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selectHousePart : MonoBehaviour {

    public GameObject currGO;
    public GameObject clickedGO;

    public void Select(GameObject clickedGO)
    {
            currGO = clickedGO;
    }
}
