using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class color : MonoBehaviour
{
    string objeto;
    string palavra;
    bool verifica;
    bool palac;

    void Start()

    
    {
        GetComponent<Renderer>().material.color = Color.blue;
        palavra = "CA";
    }

    // Update is called once per frame
    void Update() 
    {
    }

    void OnTriggerEnter(Collider other){        
        //Debug.Log(GameControllerSingleton.Instance.MyTestString);

        objeto = gameObject.name;
        objeto = objeto.Substring(5);
        verifica = palavra.Contains(objeto);

        //Debug.Log(teste);
        if (verifica)
        {   
            GetComponent<Renderer>().material.color = Color.yellow;
            int t = Int32.Parse(other.name);
            string teste = palavra.Substring(t , 1);            
            if (objeto.Contains(teste)){
                GetComponent<Renderer>().material.color = Color.green;                
                GameControllerSingleton.Instance.nextLevel();
            }
        } else {
            GetComponent<Renderer>().material.color = Color.red;
        }

        //GameControllerSingleton.Instance.nextLevel();
    }

    void OnTriggerExit(Collider other) {
        GetComponent<Renderer>().material.color = Color.blue;
    }
}
