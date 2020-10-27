using PedometerU;
using System;
using UnityEngine;
    using UnityEngine.UI;

    public class StepCounter : MonoBehaviour
    {

        public Text stepText, stepsCount, distanceText;
        private Pedometer pedometer;
        private int initialSteps = 0;
        

        private void Start()
        {
        setInitialSteps();
        
        // Create a new pedometer
        pedometer = new Pedometer(OnStep);
            // Reset UI
            //OnStep(0, 0);
            // Reset UI every 24 hours
        }

    private void setInitialSteps()
    {
        DateTime dateTime = DateTime.Today;
        String date = dateTime.ToString("dd");
        String getDate = PlayerPrefs.GetString("date", "_empty_");
        int steps = PlayerPrefs.GetInt("steps", -100);

        if ((getDate != "_empty_") && (getDate != date)) // already saved date on user mobile and that date is not equal to today's date
        {
            PlayerPrefs.SetString("date", date);
            PlayerPrefs.SetInt("steps", 0);
            initialSteps = 0;
        }
        else if ((getDate != "_empty_") && (getDate == date)) // already saved date on user mobile and that date is equal to today's date
        {
            if (steps != -100)
            {
                initialSteps = steps;
            }
        } else                                          // date is not saved on user mobile
        {
            PlayerPrefs.SetString("date", date);
            if (steps != -100)
            {
                initialSteps = steps;
            }
        }
        stepsCount.text = "steps " + initialSteps.ToString();
        stepText.text = initialSteps.ToString();
    }

        private void OnStep(int steps, double distance)
        {
        // Display the values // Distance in feet
            steps += initialSteps;
            stepText.text = steps.ToString();
            stepsCount.text = "steps " + steps.ToString();
        distanceText.text = (distance * 3.28084).ToString("F2") + " ft";
            PlayerPrefs.SetInt("steps", steps);
        }

    

        private void OnDisable()
        {
            // Release the pedometer
            pedometer.Dispose();
            pedometer = null;
        }
    }



