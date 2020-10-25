using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;

public class CharacterControllerCube : MonoBehaviour
{
    private Transform tf_;
    // Start is called before the first frame update
    void Start()
    {
        tf_ = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
            tf_.Translate( Vector3.forward * Time.deltaTime);
            Debug.Log("up");
    }
}
