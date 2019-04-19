using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullettest : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform BulletTform;
    public GameObject bullets;



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            bullets = Instantiate(bullets, BulletTform.transform.position, BulletTform.transform.rotation) as GameObject;

          
        }
    }
}
