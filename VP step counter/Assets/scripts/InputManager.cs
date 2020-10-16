using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InputManager : MonoBehaviour
{
    public InputField inputField;
    private string username;

    public void OnSubmit()
    {
        username = inputField.text;
        Debug.Log("Username is " + username);
    }

   

}