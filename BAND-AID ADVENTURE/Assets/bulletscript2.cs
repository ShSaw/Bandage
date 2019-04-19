using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletscript2 : MonoBehaviour
{

    Transform BulletTform;
    public GameObject bullets;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
                    bullets = Instantiate(bullets, BulletTform.transform.position, BulletTform.transform.rotation) as GameObject;
        }
    }
}
