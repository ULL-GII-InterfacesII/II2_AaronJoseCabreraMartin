using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;

public class Sphere : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            //                                                          R                                   G                                B                            alpha
            GetComponent<Renderer>().material.color = new Color(UnityEngine.Random.Range(0F,1F), UnityEngine.Random.Range(0F, 1F), UnityEngine.Random.Range(0F, 1F), UnityEngine.Random.Range(0F, 1F));
        }
    }
}
