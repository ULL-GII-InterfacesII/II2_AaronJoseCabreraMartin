using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;

public class CharacterControllerCube : MonoBehaviour
{
    public int velocity_;
    Transform tf_;
    // Start is called before the first frame update
    void Start()
    {
        tf_ = GetComponent<Transform>();
        velocity_ = 10;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("up"))
        {
            tf_.Translate(velocity_ * Vector3.forward * Time.deltaTime);
            //Debug.Log("up");
        }
        else if(Input.GetKey("down"))
        {
            tf_.Translate(velocity_ * Vector3.back * Time.deltaTime);
            //Debug.Log("down");
        }
        else if (Input.GetKey("left"))
        {
            tf_.Translate(velocity_ * Vector3.left * Time.deltaTime);
            //Debug.Log("left");
        }
        else if (Input.GetKey("right"))
        {
            tf_.Translate(velocity_ * Vector3.right * Time.deltaTime);
            //Debug.Log("right");
        }

    }
}
