using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{


    public GameObject Spawn;
    public GameObject cat1;
    public GameObject cat2;
    public GameObject cat3;

    

    private GameObject cat; 
    private GameObject rb;
    


    // Update is called once per frame
    void Update()
    {
        
        if (Time.frameCount % 60 == 0){
            switch (Random.Range(1, 4))
            {
                case 1:
                    cat = cat1;
                    break;
                case 2:
                    cat = cat2;
                    break;
                case 3:
                    cat = cat3;
                    break;
            }
            rb = Instantiate(cat, Spawn.transform);
            rb.GetComponent<Rigidbody2D>().AddForce(new Vector2(80, 0));
            
        }
    }
}
