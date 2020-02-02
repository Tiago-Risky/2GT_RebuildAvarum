using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Matching_Test : MonoBehaviour {

    public static string selected = "None";

    Dictionary<string, string> matches = new Dictionary<string, string>{
        {"A1","A2"},{"A4","A6"},{"A3","A5"}
    };

    Dictionary<string, string> matched;

    public void Match(string Pressed) {
        
    }
}
