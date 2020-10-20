using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    public GameObject objPrefab;
    public GameObject ground;
    private int count = 0;

    public void spawnObject()
    {
        Instantiate(objPrefab, new Vector3(count, 0, 0), Quaternion.identity, ground.transform);
        count += 2;
    }
}
