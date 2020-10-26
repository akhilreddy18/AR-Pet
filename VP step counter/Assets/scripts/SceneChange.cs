using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public void OnScenechange(string SceneName)
    {

        Application.LoadLevel(SceneName);
    }

    public void checkPlayerPrefs()
    {
        String playerPrefsName = PlayerPrefs.GetString("username", "_empty_");
        if (playerPrefsName == "_empty_")
        {
            Application.LoadLevel("1-start");
        }
        else
        {
            Application.LoadLevel("2-main");
        }
    }
}
