using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


    public class DelayLinearHealthBar : MonoBehaviour
    {
        [Header("Reference to health")]
        //max player health
        public float maxHealth;
        //delayed player health
        public float delayHealth;
        //player current health
        public float currentHealth;
        //Delay speed
        public float delaySpeed = 5f;

        //reference health slider
        public Slider healthSlider;

        public Image healthFill;
        public void delayhealthvoid()
        {


            //health slider updates when current slider changes but needs to stay between 0 and max
            healthSlider.value = Mathf.Clamp01(currentHealth / maxHealth);
        //if our current health is going to be less than out delayhealth we need to be able to bring our delayhealth down by our speed over time
        if(currentHealth > delayHealth)
            {
                delayHealth -= delaySpeed * Time.deltaTime;
            }
            //delay slider's value to be set to equal delayhealth ammount between its minimum and its maximum values
            healthSlider.value = delayHealth;

    }
        private void Update()
        {

            //optional-----> to manage the healthbar make sure foreground fill is disabled on death and enabled on revive
            if (currentHealth <= 0 && healthFill.enabled)
            {
                //dead = no filled bar
                healthFill.enabled = false;
                Debug.Log("you dead");
            }

            //once delayhealth is empty turn off background fill upon revive turn on fill make sure delayhealth and slider value are full
            if (!healthFill.enabled && currentHealth > 0)
            {
                //if alive you bar is there
                healthFill.enabled = enabled;
                Debug.Log("you alive");
            }

           

           
        }
    }

