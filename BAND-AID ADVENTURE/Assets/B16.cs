using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class B16 : MonoBehaviour
{
    Transform tform;
    Animator anim;
    arm arm;
    bool active;
    public float score = 0;
    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        this.anim = GetComponent<Animator>();
        arm = FindObjectOfType<arm>();
        active = true;
        this.tform = GetComponent<Transform>();
    }
    // Update is called once per frame
    void Update()
    {
        anim.SetFloat("Time", arm.stopWatch.ElapsedMilliseconds);
        if (active)
        {
            if (arm.stopWatch.ElapsedMilliseconds > 10200)
            {
                tform.position = new Vector2(tform.position.x + (float)-1.3, tform.position.y);
            }
            if (tform.position.x >= -55 && tform.position.x <= -24 && Input.GetKeyDown("space"))
            {
                score += 300;
            }
            else if (Input.GetKeyDown("space"))
            {
                //score -= 50;
            }
        }
        if (tform.position.x < -35)
        {
            anim.SetBool("Dead", true);
        }
        if (tform.position.x < -50)
        {
            active = false;
            tform.gameObject.SetActive(false);
        }
    }
}