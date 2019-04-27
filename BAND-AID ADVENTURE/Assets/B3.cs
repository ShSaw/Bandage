using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class B3 : MonoBehaviour
{
    Transform tform;
    public float score = 0;
    bool active;
    arm arm;
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        this.anim = GetComponent<Animator>();
        arm = FindObjectOfType<arm>();
        this.tform = GetComponent<Transform>();
        active = true;
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetFloat("Time", arm.stopWatch.ElapsedMilliseconds);
        if (active)
        {
            if (arm.stopWatch.ElapsedMilliseconds > 6350)
            {
                tform.position = new Vector2(tform.position.x + (float)-1.3, tform.position.y);
            }
            if (tform.position.x >= -45 && tform.position.x <= -24 && Input.GetKeyDown("space"))
            {
                score += 300;
            }
            else if (Input.GetKeyDown("space"))
            {
                //score -= 50;
            }
        }
        if (tform.position.x < -50)
        {
            active = false;
            tform.gameObject.SetActive(false);
        }
    }

    public float getScore()
    {
        return score;
    }
}