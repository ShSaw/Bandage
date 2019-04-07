using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class bullet3 : MonoBehaviour
{
    Transform tform;
    Animator anim;
    Stopwatch stopWatch;
    float score = 0;
    public Text scoreText; 
    // Start is called before the first frame update
    void Start()
    {
        this.anim = GetComponent<Animator>();
        stopWatch = new Stopwatch();
        stopWatch.Start();
        this.tform = GetComponent<Transform>();
        scoreText.text = "Score: " + score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetFloat("Time", stopWatch.ElapsedMilliseconds/1000);
        if (stopWatch.ElapsedMilliseconds > 3000)
        {
            tform.position = new Vector2(tform.position.x + (float)-1.3, tform.position.y);
        }
        if (tform.position.x >= -30 && tform.position.x <= -18 && Input.GetKeyDown("space"))
        {
            UnityEngine.Debug.Log("score: " + score);
            score += 300;
        } else if (Input.GetKeyDown("space")) {
            UnityEngine.Debug.Log("score: " + score);
            score -= 50;
        }
        scoreText.text = "Score: " + score.ToString();
    }

    public float getScore()
    {
        return score;
    }
}
