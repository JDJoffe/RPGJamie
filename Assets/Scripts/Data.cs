using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

     //wont inherit from monobehaviour and cant be attatched]
public class Data
{
   //vars
    public int Level;
    public float x, y, z;
    public string PlayerName;
    public float maxHp, currHp;

    //constructor to default data
    public Data (Player Player)
    {
        Level = Player.Level;
        PlayerName = Player.PlayerName;
        currHp = Player.currHealth;
        maxHp = Player.maxHealth;
        x = Player.x;
        y = Player.y;
        z = Player.z;
    }
}
