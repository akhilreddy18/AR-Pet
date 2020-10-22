﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InputManager : MonoBehaviour
{
    public InputField usernameInput;
    public InputField goalInput;
    public Slider percentageSlider;
    public static string username;
    public static int Goal;
    public static float percentage;
    public GameObject nameDisplay;
    public GameObject goalDisplay;
    public GameObject valueDisplay;

    public void OnSubmit()
    {
        username = usernameInput.text;
        Debug.Log("Username is " + username);

    }

    public void StoreName()
    {
        username = usernameInput.text;
        nameDisplay.GetComponent<Text>().text = username;
    }
   
    public void StoreGoal()
    {
        Goal = int.Parse(goalInput.text);
        goalDisplay.GetComponent<Text>().text = "GOAL: " + Goal + " steps";
    }

    public void onValueChange()
    {
        percentage = percentageSlider.value;
        valueDisplay.GetComponent<Text>().text = percentage.ToString("p2") + "cpmpleted.";
    }



}