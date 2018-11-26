
using UnityEngine;
using UnityEngine.UI;

public class RageValue : MonoBehaviour {

    public global_var globarvar;
	
	
	// Update is called once per frame
	void Update () {
        GetComponent<Slider>().value = globarvar.score;
	}
}
