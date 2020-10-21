using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InputManager : MonoBehaviour
{
    public InputField usernameInput;
    public InputField goalInput;
    public static string username;
    public string Goal;
    public GameObject nameDisplay;
    public GameObject goalDisplay;

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
        Goal = goalInput.text;
        goalDisplay.GetComponent<Text>().text = "GOAL: " + Goal + " steps";
    }

}