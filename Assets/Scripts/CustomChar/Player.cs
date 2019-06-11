using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    //essential variables for the player
    public int Level;
    public float Health;
    public float maxHealth, currHealth;
    public string PlayerName;
    public HealthBar health;
    public CheckPoint checkPoint;
    public float x, y, z;

    // Use this for initialization
    public void Savefunction()
    {
        Saves.SaveData(this);
        //save health and maxhealth
        maxHealth = health.maxHealth;
        currHealth = health.curHealth;
        //save position
        
        x = checkPoint.curCheckPoint.position.x;
        y = checkPoint.curCheckPoint.position.y;
        z = checkPoint.curCheckPoint.position.z;
    }

    // Update is called once per frame
   public void LoadData()
    {
        //load the data
        Data data = Saves.LoadData(this);
        Level = data.Level;
        PlayerName = data.PlayerName;
        currHealth = data.currHp;
        health.curHealth = currHealth;
        maxHealth = data.maxHp;
        health.maxHealth = maxHealth;
        x = data.x;
        y = data.y;
        z = data.z;
        this.transform.position = new Vector3(x, y, z);
    }
    private void Awake()
    {
        LoadData();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F12))
        {
            Savefunction();
        }
        if (Input.GetKeyDown(KeyCode.F11))
        {
            LoadData();
        }
    }
}
