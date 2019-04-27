using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Samurai : MonoBehaviour
{
    Animator anim;
    public bool click;
 
    // Start is called before the first frame update
    void Start()
    {
        this.anim = GetComponent<Animator>();
        click = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            anim.SetBool("Click", true);
            click = true;
        }
        else
        {
            anim.SetBool("Click", false);
            click = false;
        }
    }
}
