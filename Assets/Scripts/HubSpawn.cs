using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HubSpawn : MonoBehaviour {
    public GameObject[] cats = new GameObject[5];
    public bool kill;

    private void Start()
    {
        for (int i = 0; i < cats.Length; i++)
        {
            cats[i].GetComponent<CatController>().spawned = false;
        }
    }

    private void Update()
    {
        kill = false;
        if (!kill){
            for (int i = 0; i < cats.Length; i++){
                if (cats[i].GetComponent<CatController>().inTeam && !cats[i].GetComponent<CatController>().spawned){
                    GameObject cat = Instantiate(cats[i], transform);
                    cats[i].GetComponent<CatController>().spawned = true;
                }
            }
        }
        if (kill)
        {
            foreach (Transform child in transform)
            {
                Destroy(child.gameObject);
            }
        }
       
    }
}
