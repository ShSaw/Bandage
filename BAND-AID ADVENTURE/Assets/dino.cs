using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;
using UnityEngine.UI;

public class dino : MonoBehaviour
{
    public Stopwatch stopWatch;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        stopWatch = new Stopwatch();
        stopWatch.Start();
        this.anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetFloat("Time", stopWatch.ElapsedMilliseconds);
    }
}
