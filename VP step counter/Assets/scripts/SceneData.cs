using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneData : MonoBehaviour
{
    public static string un;
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
    }
}
