using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneData : MonoBehaviour
{
    public static string un;
    public static float sCompleted;
    static SceneData current;

    void Start()
    {
        if(current != null)
        {
            Destroy(this.gameObject);
            return;
        }
        current = this;
        GameObject.DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        un = InputManager.username;
        sCompleted = DataUpdater.stepCompleted;
    }
}
