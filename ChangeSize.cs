using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSize : MonoBehaviour
{
    private Transform tf_;
    public GameObject player_;
    public GameObject[] esferasA_;
    public GameObject[] esferas_;
    public float distanciaMinima_; //distancia antes de encoger/crecer
    public float velocidadCrecimiento_;

    // Start is called before the first frame update
    void Start()
    {
        tf_ = GetComponent<Transform>();
        player_ = GameObject.FindWithTag("Player");
        esferasA_ = GameObject.FindGameObjectsWithTag("esferasA");
        esferas_ = GameObject.FindGameObjectsWithTag("esfera");
        distanciaMinima_ = 5F;
        velocidadCrecimiento_ = 0.1f;
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(player_.transform.position, tf_.position) < distanciaMinima_)
        {
            Debug.Log("decrezco");
            tf_.localScale -= new Vector3(velocidadCrecimiento_* Time.deltaTime, velocidadCrecimiento_ * Time.deltaTime, velocidadCrecimiento_ * Time.deltaTime);
        }

        for (int i = 0; i < esferasA_.Length; i++)
        {
            if (Vector3.Distance(esferasA_[i].transform.position, tf_.position) < distanciaMinima_)
            {
                Debug.Log("crezco");
                tf_.localScale += new Vector3(velocidadCrecimiento_ * Time.deltaTime, velocidadCrecimiento_ * Time.deltaTime, velocidadCrecimiento_ * Time.deltaTime);
            }
        }

        for (int i = 0; i < esferas_.Length; i++)
        {
            if (Vector3.Distance(esferas_[i].transform.position, tf_.position) < distanciaMinima_)
            {
                Debug.Log("crezco");
                tf_.localScale += new Vector3(velocidadCrecimiento_ * Time.deltaTime, velocidadCrecimiento_ * Time.deltaTime, velocidadCrecimiento_ * Time.deltaTime);
            }
        }
    }
}
