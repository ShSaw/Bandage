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
    sc b1;
    Bullet2script b2;
    B3 b3;
    B4 b4;
    B5 b5;
    B6 b6;
    B7 b7;
    B8 b8;
    B9 b9;
    B10 b10;
    B11 b11;
    B12 b12;
    B13 b13;
    B14 b14;
    B15 b15;
    B16 b16;
    B17 b17;
    B18 b18;
    B19 b19;
    B20 b20;
    B21 b21;
    B22 b22;
     // Start is called before the first frame update
    void Start()
    {
        stopWatch = new Stopwatch();
        stopWatch.Start();
        scoreText.text = "Score: " + score.ToString();
        score = 0;
        b2 = FindObjectOfType<Bullet2script>();
        b1 = FindObjectOfType<sc>();
        b3 = FindObjectOfType<B3>();
        b4 = FindObjectOfType<B4>();
        b5 = FindObjectOfType<B5>();
        b6 = FindObjectOfType<B6>();
        b7 = FindObjectOfType<B7>();
        b8 = FindObjectOfType<B8>();
        b9 = FindObjectOfType<B9>();
        b10 = FindObjectOfType<B10>();
        b11 = FindObjectOfType<B11>();
        b12 = FindObjectOfType<B12>();
        b13 = FindObjectOfType<B13>();
        b14 = FindObjectOfType<B14>();
        b15 = FindObjectOfType<B15>();
        b16 = FindObjectOfType<B16>();
        b17 = FindObjectOfType<B17>();
        b18 = FindObjectOfType<B18>();
        b19 = FindObjectOfType<B19>();
        b20 = FindObjectOfType<B20>();
        b21 = FindObjectOfType<B21>();
        b22 = FindObjectOfType<B22>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + score.ToString();

        score = b1.score + b2.score + b3.score + b4.score + b5.score + b6.score + b7.score + b8.score + b9.score + b10.score + b11.score + b12.score + b13.score +
        b14.score + b15.score + b16.score + b17.score + b18.score + b19.score + b20.score + b21.score + b22.score;
}
}
