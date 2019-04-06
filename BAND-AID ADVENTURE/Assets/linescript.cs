using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class linescript : MonoBehaviour
{
    BoxCollider2D boxCollider2D;

    // Start is called before the first frame update
    void Start()
    {
        this.boxCollider2D = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Touching");
    }
}
