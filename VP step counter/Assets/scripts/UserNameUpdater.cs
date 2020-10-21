using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UserNameUpdater : MonoBehaviour
{
    public GameObject textDisplay;
    public string username;

    private void Start()
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
    // Update is called once per frame
    void Update()
    {
        
        
    }
}
