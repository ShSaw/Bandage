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
    B23 b23;
    B24 b24;
    B25 b25;
    B26 b26;
    B27 b27;
    B28 b28;
    B29 b29;
    B30 b30;
    B31 b31;
    B32 b32;
    B33 b33;
    B34 b34;
    B35 b35;
    B36 b36;
    B37 b37;
    B38 b38;
    B39 b39;
    B40 b40;
    B41 b41;
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
        b23 = FindObjectOfType<B23>();
        b24 = FindObjectOfType<B24>();
        b25 = FindObjectOfType<B25>();
        b26 = FindObjectOfType<B26>();
        b27 = FindObjectOfType<B27>();
        b28 = FindObjectOfType<B28>();
        b29 = FindObjectOfType<B29>();
        b30 = FindObjectOfType<B30>();
        b31 = FindObjectOfType<B31>();
        b32 = FindObjectOfType<B32>();
        b33 = FindObjectOfType<B33>();
        b34 = FindObjectOfType<B34>();
        b35 = FindObjectOfType<B35>();
        b36 = FindObjectOfType<B36>();
        b37 = FindObjectOfType<B37>();
        b38 = FindObjectOfType<B38>();
        b39 = FindObjectOfType<B39>();
        b40 = FindObjectOfType<B40>();
        b41 = FindObjectOfType<B41>();




    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + score.ToString();

        score = b1.score + b2.score + b3.score + b4.score + b5.score + b6.score + b7.score + b8.score + b9.score + b10.score + b11.score + b12.score + b13.score +
        b14.score + b15.score + b16.score + b17.score + b18.score + b19.score + b20.score + b21.score + b22.score + b23.score + b24.score + b25.score + b26.score + b27.score +
        b28.score + b29.score + b30.score + b31.score + b32.score + b33.score + b34.score + b35.score + b36.score + b37.score + b38.score + b39.score + b40.score + b41.score;
}
}
