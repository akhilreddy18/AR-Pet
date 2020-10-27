using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using PedometerU;

public class MainPage : MonoBehaviour
{
    public Text stepsDisplay;
    private int initialMainSteps;
    private int mainSteps;
    private Pedometer pedometer;

    private void Start()
    {
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
