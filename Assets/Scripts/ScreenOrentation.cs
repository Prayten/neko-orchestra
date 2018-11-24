using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenOrentation : MonoBehaviour {

    // Use this for initialization
    void Start(){
        Screen.autorotateToPortrait = false;

        Screen.autorotateToPortraitUpsideDown = false;

        Screen.orientation = ScreenOrientation.AutoRotation;
    }
}
