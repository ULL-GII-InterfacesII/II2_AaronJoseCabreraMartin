using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;

public class CharacterControllerCube : MonoBehaviour
{
    private Transform tf_;
    public float velocity_;
    // Start is called before the first frame update
    void Start()
    {
        tf_ = GetComponent<Transform>();
        velocity_ = 15.5F;
        //GetComponent<Transform>().Translate(new Vector3(3, 3, 3));
        //gira al rededor de eje, punto y un angulo
        //GetComponent<Transform>().RotateAround(new Vector3(0, 30, 0), new Vector3(0, 0, 0), 30);
        //GetComponent<Transform>().rotation = Quaternion.LookRotation(GetComponent<Transform>().position);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("up"))
        {
            tf_.Translate(velocity_ * Vector3.forward * Time.deltaTime);
            //Debug.Log("up");
        }

        if (Input.GetKey("down"))
        {
            tf_.Translate(velocity_ * Vector3.back * Time.deltaTime);
            //Debug.Log("down");
        }

        if (Input.GetKey("left"))
        {
            tf_.Translate(velocity_ * Vector3.left * Time.deltaTime);
            //Debug.Log("left");
        }

        if (Input.GetKey("right"))
        {
            tf_.Translate(velocity_ * Vector3.right * Time.deltaTime);
            //Debug.Log("right");
        }
        //2)d)
        if (Input.GetKey("a")) 
        {
            tf_.Rotate(0, -velocity_ * Time.deltaTime, 0);
        }

        if (Input.GetKey("d"))
        {
            tf_.Rotate(0, velocity_ * Time.deltaTime, 0);
        }

    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "esferasA" && Input.GetKey("space"))
        {
            //                                                          fuerza,posicion,radio,fuerzahacia arriba, forcemode default ForceMode.Force
            other.gameObject.GetComponent<Rigidbody>().AddExplosionForce(250.5F, tf_.position, 0.5F,300.5F, ForceMode.Force);
        }
    }
}
