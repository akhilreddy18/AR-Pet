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
        if (go == null)
        {
            Debug.LogError("Failed to find an aobject named 'UserName'");
            this.enabled = false;
            return;
        }


        username = SceneData.un;
        textDisplay.GetComponent<Text>().text = username;

    }

    void Update()
    {
        Percent.minValue = 0;
        Percent.maxValue = 1;
        Percent.wholeNumbers = true;
        PercentValueUpdate();
        
    }

    private void PercentValueUpdate()
    {
        Percent.value = float.Parse(stepCounter.stepText.text) / (float)InputManager.Goal;
        stepCompleted = Percent.value;
    }
}

    
