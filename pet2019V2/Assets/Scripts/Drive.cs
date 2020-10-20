using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Drive : MonoBehaviour
{
    float speed = 0.3F;
    float rotationSpeed = 50.0F;
    Animator anim;

    void Start()
    {
        anim = this.GetComponent<Animator>();
    }

    void Update()
    {
        float translation = CrossPlatformInputManager.GetAxis("Vertical") * speed;
        float rotation = CrossPlatformInputManager.GetAxis("Horizontal") * rotationSpeed;
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;
        transform.Translate(0, 0, translation);
        transform.Rotate(0, rotation, 0);

        if (translation > 0)
        {
            anim.SetBool("Walk", true);
            anim.SetFloat("speed", 1.0f);
        }
        else if (translation < 0)
        {
            anim.SetBool("Walk", true);
            anim.SetFloat("speed", -1.0f);
        }
        else
            anim.SetBool("Walk", false);
    }
}
