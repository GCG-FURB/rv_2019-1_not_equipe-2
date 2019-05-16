using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class color : MonoBehaviour
{
    string objeto;
    string posicao;
    string palavra;
    bool verifica;
    // Start is called before the first frame update
    void Start()
    {
        //
        GetComponent<Renderer>().material.color = Color.red;
        palavra = "CASA";

        objeto = gameObject.name;
        objeto = objeto.Substring(5);
        verifica = palavra.Contains(objeto);
        if (verifica)
        {
            if (gameObject.transform.position.x < gameObject.transform.position.x)
            {
                GetComponent<Renderer>().material.color = Color.green;
            }
            //Debug.Log(gameObject.transform.position.x);
            GetComponent<Renderer>().material.color = Color.yellow;
        }
    }

    // Update is called once per frame
    void Update() 
    {
        
        
    }

    void colors()
    {
        
    }

    void OnTriggerEnter(Collider outro){
        GetComponent<Renderer>().material.color = Color.green;
       // Debug.Log("teste2");
    }

    void OnTriggerExit(Collider other) {
        GetComponent<Renderer>().material.color = Color.red;
    }

    /* void OnCollisionEnter(Collision other) {
        GetComponent<Renderer>().material.color = Color.green;
        Debug.Log("teste3");
    }*/
}
