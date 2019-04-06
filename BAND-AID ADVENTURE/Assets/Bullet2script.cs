using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Diagnostics;
using UnityEngine;

public class Bullet2script : MonoBehaviour
{
    Transform tform;
    Animator anim;
    Stopwatch stopWatch;
    // Start is called before the first frame update
    void Start()
    {
        this.anim = GetComponent<Animator>();
        stopWatch = new Stopwatch();
        stopWatch.Start();
        this.tform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetFloat("Time", stopWatch.ElapsedMilliseconds/1000);
        if (stopWatch.ElapsedMilliseconds > 2000)
        {
            tform.position = new Vector2(tform.position.x + (float)-1.3, tform.position.y);
        }
    }
}
