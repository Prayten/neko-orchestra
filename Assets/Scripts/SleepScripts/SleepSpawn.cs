using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SleepSpawn : MonoBehaviour
{
    public GameObject sleepSpawn;
    public GameObject sleepCat;

    private int speed = 30;
    private int degree = 120;

    

    void Update()
    {
        if(Time.frameCount % 60 == 0)
        {


            Debug.Log("Start SleepSpawn");
            GameObject cat = Instantiate(sleepCat, sleepSpawn.transform);
            cat.transform.parent = null;

            if (sleepSpawn.transform.position.x < 0 && sleepSpawn.transform.position.y < 0)
            {
                cat.GetComponent<Rigidbody2D>().AddForce(new Vector2(Random.Range(speed, degree), Random.Range(speed, degree)));
            }
            else if(sleepSpawn.transform.position.x > 0 && sleepSpawn.transform.position.y < 0)
            {
                cat.GetComponent<Rigidbody2D>().AddForce(new Vector2(Random.Range(-speed, -degree), Random.Range(speed, degree)));
            }
            else if (sleepSpawn.transform.position.x > 0 && sleepSpawn.transform.position.y > 0)
            {
                cat.GetComponent<Rigidbody2D>().AddForce(new Vector2(Random.Range(-speed, -degree), Random.Range(-speed, -degree)));
            }
            else if (sleepSpawn.transform.position.x < 0 && sleepSpawn.transform.position.y > 0)
            {
                cat.GetComponent<Rigidbody2D>().AddForce(new Vector2(Random.Range(speed, degree), Random.Range(-speed, -degree)));
            }
        }
    }


}
