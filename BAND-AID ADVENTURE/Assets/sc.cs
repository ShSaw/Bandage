using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sc : MonoBehaviour
{
    Transform Tform;

    // Start is called before the first frame update
    void Start()
    {
        Tform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    { 
        Tform.position = new Vector2(Tform.position.x + (float) -1.3, Tform.position.y);
    }
}
