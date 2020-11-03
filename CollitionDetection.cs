using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollitionDetection : MonoBehaviour
{
    private Transform tf_;
    public float velocity_;
    // Start is called before the first frame update
    void Start()
    {
        tf_ = GetComponent<Transform>();
        velocity_ = 15.5F;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("i"))
        {
            tf_.Translate(velocity_ * Vector3.forward * Time.deltaTime);
        }

        if (Input.GetKey("m"))
        {
            tf_.Translate(velocity_ * Vector3.back * Time.deltaTime);
        }

        if (Input.GetKey("j"))
        {
            tf_.Translate(velocity_ * Vector3.left * Time.deltaTime);
        }

        if (Input.GetKey("l"))
        {
            tf_.Translate(velocity_ * Vector3.right * Time.deltaTime);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter with " + other.gameObject.name);
    }

    void OnTriggerStay(Collider other)
    {
        Debug.Log("OnTriggerStay with " + other.gameObject.name);
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log("OnTriggerExit with " + other.gameObject.name);
    }

    void OnCollisionEnter(Collision other)
    {
        Debug.Log("OnCollisionEnter with " + other.gameObject.name);
    }

    void OnCollisionStay(Collision other)
    {
        Debug.Log("OnCollisionStay with " + other.gameObject.name);
    }

    void OnCollisionExit(Collision other)
    {
        Debug.Log("OnCollisionExit with " + other.gameObject.name);
    }
}
