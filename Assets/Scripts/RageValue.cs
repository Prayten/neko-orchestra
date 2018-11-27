
using UnityEngine;
using UnityEngine.UI;

public class RageValue : MonoBehaviour {

    public global_var globalvar;
	
    void Start()
    {
        globalvar.GetComponent<global_var>().cat_counter = 0;
    }
	
	// Update is called once per frame
	void Update () {
        if (Time.frameCount % 60 == 0 && Time.timeScale > 0)
        {
            GetComponent<Slider>().value += globalvar.cat_counter;
        }
	}
}
