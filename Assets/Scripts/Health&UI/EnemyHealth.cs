using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    [Header("Enemy Var")]
    //max and current health
    public float maxHP = 100, currHP = 100;
    //ref to canvas and slider
    public Slider healthBar;
    public Canvas myCanvas;
    // Use this for initialization
    void Start()
    {
        //find and assign var to components
        myCanvas = transform.Find("Canvas").GetComponent<Canvas>();
        healthBar = myCanvas.transform.Find("Slider").GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        //every frame divide curr hp by max hp and get a value between 0 and 1
        healthBar.value = Mathf.Clamp01(currHP / maxHP);
        //every frame face the player camera 
        myCanvas.transform.LookAt(Camera.main.transform);
    }
}
