using System.Collections;
using System.Collections.Generic;
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
        velocity_ = 1.5F;
    }

    // Update is called once per frame
    void Update()
    {
            tf_.Translate( velocity_ * Vector3.forward * Time.deltaTime);
            Debug.Log("up");
    }
}
