using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cat_pick : MonoBehaviour {

    public int cat_count;
    public GameObject spawn;
    public GameObject[] cats;
    public GameObject cont;
    public Button cat;

    private void Start()
    {
        cat.onClick.AddListener(TaskOnClicktakecat1);
        cat.onClick.AddListener(TaskOnClicktakecat2);
        cat.onClick.AddListener(TaskOnClicktakecat3);
        cat.onClick.AddListener(TaskOnClicktakecat4);
        cat.onClick.AddListener(TaskOnClicktakecat5);
        cat.onClick.AddListener(TaskOnClicktakecat1_1);
        cat.onClick.AddListener(TaskOnClicktakecat2_1);
        cat.onClick.AddListener(TaskOnClicktakecat3_1);
        cat.onClick.AddListener(TaskOnClicktakecat4_1);
        cat.onClick.AddListener(TaskOnClicktakecat5_1);
        cat.onClick.AddListener(TaskOnClicktakeconti);
    }

    public void TaskOnClicktakecat1()
    {
        cat_count += 1;
        cats[0].GetComponent<Controler>().inTeam = true;
    }
    public void TaskOnClicktakecat1_1()
    {
        cat_count -= 1;
        cats[0].GetComponent<Controler>().inTeam = false;

    }
    public void TaskOnClicktakecat2()
    {
        cat_count += 1;
        cats[1].GetComponent<Controler>().inTeam = true;
    }
    public void TaskOnClicktakecat2_1()
    {
        cat_count -= 1;
        cats[1].GetComponent<Controler>().inTeam = false;
    }
    public void TaskOnClicktakecat3()
    {
        cat_count += 1;
        cats[2].GetComponent<Controler>().inTeam = true;
    }
    public void TaskOnClicktakecat3_1()
    {
        cat_count -= 1;
        cats[2].GetComponent<Controler>().inTeam = false;
    }
    public void TaskOnClicktakecat4()
    {
        cat_count += 1;
        cats[3].GetComponent<Controler>().inTeam = true;
    }
    public void TaskOnClicktakecat4_1()
    {
        cat_count -= 1;
        cats[3].GetComponent<Controler>().inTeam = false;
    }
    public void TaskOnClicktakecat5()
    {
        cat_count += 1;
        cats[4].GetComponent<Controler>().inTeam = true;
    }
    public void TaskOnClicktakecat5_1()
    {
        cat_count -= 1;
        cats[4].GetComponent<Controler>().inTeam = false;
    }
    public void TaskOnClicktakeconti()
    {
        spawn.GetComponent<HubSpawn>().kill = true;
    }
    private void Update()
    {
        if (cat_count > 2){
            cont.SetActive(true);
        } else { cont.SetActive(false); }
    }
}
