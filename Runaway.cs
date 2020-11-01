using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class Runaway : MonoBehaviour
{
    public GameObject player_;
    private Transform tf_;
    private Rigidbody rb_;
    public float distanciaMinima_; //distancia antes de huir
    public float velocityMax_ ;

    // Start is called before the first frame update
    void Start()
    {
        tf_ = GetComponent<Transform>();
        rb_ = GetComponent<Rigidbody>();
        player_ = GameObject.FindWithTag("Player");
        velocityMax_ = 17F;
        distanciaMinima_ = 6.5F;
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(player_.transform.position,tf_.position) < distanciaMinima_){
            rb_.AddForce((tf_.position - player_.transform.position)*(velocityMax_ - Vector3.Distance(player_.transform.position, tf_.position)));
        }
    }
}
