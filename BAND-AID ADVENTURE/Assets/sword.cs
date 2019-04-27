using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sword : MonoBehaviour
{
    Samurai samurai;
    Transform tform;
    // Start is called before the first frame update
    void Start()
    {
        samurai = FindObjectOfType<Samurai>();
    }

    // Update is called once per frame
    void Update()
    {
        if (samurai.click == true)
        {
            //tform.position = new Vector2(tform.position.x, tform.position.y + (float).5);
        }
    }
}
