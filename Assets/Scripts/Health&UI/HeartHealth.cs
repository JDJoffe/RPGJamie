using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//Allow us to interact with UI elements

//this script can be found in the Component section under the option Intro PRG/Player/Health
[AddComponentMenu("Intro to RPG/Player/HeartHealth")]
public class HeartHealth : MonoBehaviour
{
    //[Header("Player Stats")]
    [Header("Player Stats")]
    //public maxHealth
    public float maxHealth;
    //public curHealth
    public float curHealth;
    //[Header("Heart Slots")]
    [Header("Heart Slots")]
    //Canvas Image heartSlots array
    public Image[] heartSlots;
    //Sprite hearts array
    public Sprite[] hearts;
    //private percent healthPerSection
    private float healthPerSection;
    #region Start
    private void Start()
    {

        UpdateHearts();
        // Run UpdateHearts
    }
    #endregion
    #region Update 
    private void Update()
    {
        //index variable starting at 0 for slot checks
        int i = 0;
        //foreach Image slot in heartSlots
        foreach (Image slot in heartSlots)
        {
            //if curHealth is greater or equal to full for this slot amount
            if (curHealth >= ((healthPerSection * 4)) + healthPerSection * 4 * i)
            {


                //Set heart to 4/4
                heartSlots[i].sprite = hearts[0];
            }
            //else if curHealth is greater or equal to 3/4 for this slot amount
            else if (curHealth >= ((healthPerSection * 3)) + healthPerSection * 4 * i)
            {
                //Set Heart to 3/4
                heartSlots[i].sprite = hearts[1];
            }

            //else if curHealth is greater or equal to 2/4 for this slot amount
            else if (curHealth >= ((healthPerSection * 2)) + healthPerSection * 4 * i)
            {
                //Set Heart to 2/4
                heartSlots[i].sprite = hearts[2];
            }
            else if (curHealth >= ((healthPerSection * 1)) + healthPerSection * 4 * i)
            {
                //else if curHealth is greater or equal to 1/4 for this slot amount
                //Set Heart to 1/4
                heartSlots[i].sprite = hearts[3];
            }
            //else
            else
            {
                heartSlots[i].sprite = hearts[4];
            }

            i++;
        }
        //we are empty
        //after checking this slot increase slot index
    }
    #endregion
    #region UpdateHearts

    private void UpdateHearts()
    {
        //calculate the health points per heart section
        healthPerSection = maxHealth / (heartSlots.Length * 4);
    }
    #endregion

}



