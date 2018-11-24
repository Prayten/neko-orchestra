using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SleepSpawn : MonoBehaviour
{
   
    public GameObject sleepCat;

    private int speed = 30;
    private int degree = 120;

    

    void Update()
    {
        if(Time.frameCount % 60 == 0 && Time.timeScale > 0)
        {
            GameObject cat = Instantiate(sleepCat, transform);
            cat.transform.parent = null;

            if (transform.position.x < 0 && transform.position.y < 0)
            {
                cat.GetComponent<Rigidbody2D>().AddForce(new Vector2(Random.Range(speed, degree), Random.Range(speed, degree)));
            }
            else if(transform.position.x > 0 && transform.position.y < 0)
            {
                cat.GetComponent<Rigidbody2D>().AddForce(new Vector2(Random.Range(-speed, -degree), Random.Range(speed, degree)));
            }
            else if (transform.position.x > 0 && transform.position.y > 0)
            {
                cat.GetComponent<Rigidbody2D>().AddForce(new Vector2(Random.Range(-speed, -degree), Random.Range(-speed, -degree)));
            }
            else if (transform.position.x < 0 && transform.position.y > 0)
            {
                cat.GetComponent<Rigidbody2D>().AddForce(new Vector2(Random.Range(speed, degree), Random.Range(-speed, -degree)));
            }
        }
    }


}
