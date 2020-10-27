using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneData : MonoBehaviour
{
    public static string un;
    public static float sCompleted;
    public static float steps;
    static SceneData current;
    private StepCounter stepCounter;

    private void Awake()
    {
        //stepCounter = GameObject.FindObjectOfType<StepCounter>();
    }
    void Start()
    {
        //if(current != null)
        //{
        //    Destroy(this.gameObject);
        //    return;
        //}
        //current = this;
        //GameObject.DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        //un = InputManager.username;
        //sCompleted = DataUpdater.stepCompleted;
        //steps = float.Parse(stepCounter.stepText.text);
    }
}
