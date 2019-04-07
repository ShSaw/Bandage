using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;
using UnityEngine.UI;

public class arm : MonoBehaviour
{
    public Stopwatch stopWatch;
    float score;
    public Text scoreText;
    Bullet2script b1;
    sc b0;

    // Start is called before the first frame update
    void Start()
    {
        stopWatch = new Stopwatch();
        stopWatch.Start();
        scoreText.text = "Score: " + score.ToString();
        b1 = FindObjectOfType<Bullet2script>();
        b0 = FindObjectOfType<sc>();
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + score.ToString();
        score = b1.score + b0.score;
    }
}
