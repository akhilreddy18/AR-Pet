using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DataUpdater : MonoBehaviour
{
    public GameObject textDisplay;
    public string username;
    public static float stepCompleted;
    public Slider Percent;
    private StepCounter stepCounter;

    private void Awake()
    {
        stepCounter = GameObject.FindObjectOfType<StepCounter>();
    }

    void Start()
    {
        GameObject go = GameObject.Find("UserName");
        String playerPrefsName = PlayerPrefs.GetString("username", "_empty_");
        int steps = PlayerPrefs.GetInt("steps", -100);
        if (go == null)
        {
            Debug.LogError("Failed to find an an object named 'UserName'");
            this.enabled = false;
            return;
        }
        if (playerPrefsName != "_empty_")
        {
            username = playerPrefsName;
            textDisplay.GetComponent<Text>().text = username;
        }
        else
        {
            username = SceneData.un;
            textDisplay.GetComponent<Text>().text = username;
        }
        if(steps != -100)
        {
            Percent.value = (float)steps / (float)InputManager.Goal;
            stepCompleted = Percent.value;
        }

    }

    void Update()
    {
        Percent.minValue = 0;
        Percent.maxValue = 1;
        
        PercentValueUpdate();
        
    }

    private void PercentValueUpdate()
    {
        Percent.value = float.Parse(stepCounter.stepText.text) / (float)InputManager.Goal;
        stepCompleted = Percent.value;
    }
}

    
