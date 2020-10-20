using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dinoController : MonoBehaviour
{

    public GameObject Dino;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = Dino.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changeAnim()
    {
        anim.SetTrigger("Walk");
    }
}
