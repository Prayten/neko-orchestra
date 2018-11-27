using UnityEngine;
using UnityEngine.UI;

public class Conductor : MonoBehaviour
{
   
    public RageValue rage;

    // Update is called once per frame
    void Update()
    {
        GetComponent<Animator>().SetInteger("cat", (int)rage.GetComponent<Slider>().value);
    }
}
