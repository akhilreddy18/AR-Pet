using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using PedometerU;
using System;

public class MainPage : MonoBehaviour
{
    public Text stepsDisplay;
    private int initialMainSteps;
    private int mainSteps;
    private Pedometer pedometer;
    public Slider health;

    private void Start()
    {
        DateTime dateTime = DateTime.Today;
        String date = dateTime.ToString("dd");
        String getDate = PlayerPrefs.GetString("date", "_empty_");
        int steps = PlayerPrefs.GetInt("steps", -100);

        if ((getDate != "_empty_") && (getDate != date)) // already saved date on user mobile and that date is not equal to today's date
        {
            if(steps != -100)
            {
                if(steps > InputManager.Goal)
                {
                    health.value += 10;
                } else
                {
                    health.value -= 10;
                }
            }
        }
        initialMainSteps = PlayerPrefs.GetInt("steps", 0);
        stepsDisplay.text = "Steps: " + initialMainSteps.ToString();
        pedometer = new Pedometer(OnStep);
    }

    
    
    private void OnStep(int steps, double distance)
        {
        // Display the values // Distance in feet
            steps += initialMainSteps;
            stepsDisplay.text = "Steps: " + steps.ToString();
            PlayerPrefs.SetInt("steps", steps);
    }

    private void OnDisable()
    {
        // Release the pedometer
        pedometer.Dispose();
        pedometer = null;
    }

}
