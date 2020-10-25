using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainPage : MonoBehaviour
{
    public GameObject stepsDisplay;
   
   

    // Update is called once per frame
    void Update()
    {
        stepsDisplay.GetComponent<Text>().text = "Steps: " + SceneData.steps;
    }
}
