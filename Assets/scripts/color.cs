using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class color : MonoBehaviour
{
    public GameObject camera;
    string objeto;
    string palavra;
    bool verifica;

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

                camera.GetComponent<cubos>().PalavraSoma();
                GetComponent<Renderer>().material.color = Color.green;   
                
                if(camera.GetComponent<cubos>().contpalavra == palavra.Length){
                    GameControllerSingleton.Instance.nextLevel();
                }                               
            }
        } else {
            GetComponent<Renderer>().material.color = Color.red;
        }
    }

    void OnTriggerExit(Collider other) {
         if (verifica)
        {   
            GetComponent<Renderer>().material.color = Color.yellow;
            int t = Int32.Parse(other.name);
            string teste = palavra.Substring(t , 1);            
            if (objeto.Contains(teste)){
                 camera.GetComponent<cubos>().PalavraSubtrai();
            } 
        }       
        GetComponent<Renderer>().material.color = Color.blue;
    }
}
