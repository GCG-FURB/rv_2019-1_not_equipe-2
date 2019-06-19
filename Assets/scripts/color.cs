using System.Text.RegularExpressions;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;



public class color :  MonoBehaviour
{
    public GameObject camera;
    string objeto;
    string palavra;
    bool verifica;
    int t = 0;
    void Start(){
        GetComponent<Renderer>().material.color = Color.blue;
               
    }

    // Update is called once per frame
    void Update() 
    {        
    }

    void OnTriggerEnter(Collider other){                
        palavra = GameControllerSingleton.Instance.getCurrentWord();        
        
        objeto = gameObject.name;
        objeto = objeto.Substring(5);
        verifica = palavra.Contains(objeto.ToLower());

        //Debug.Log(teste);
        if(Regex.IsMatch(other.name, @"^\d$")){
            if (verifica){   
                GetComponent<Renderer>().material.color = Color.yellow;
                //Debug.Log(other.name);                
                t = Int32.Parse(other.name);
                string teste = palavra.Substring(t , 1);                
                if (objeto.ToLower().Contains(teste.ToLower())){                
                    GetComponent<Renderer>().material.color = Color.green;   
                    camera.GetComponent<cubos>().PalavraSoma(t);
                    if(camera.GetComponent<cubos>().verificapalavra()){
                        GameControllerSingleton.Instance.nextLevel();
                        camera.GetComponent<cubos>().DestroiPlanos();
                        camera.GetComponent<cubos>().CriaPlanos();
                        camera.GetComponent<cubos>().zeravpalavra();
                    }                       
                }
            } else {
                GetComponent<Renderer>().material.color = Color.red;
            }
        }
    }

    void OnTriggerExit(Collider other) {
        if(Regex.IsMatch(other.name, @"^\d$")){
            if (verifica){   
                GetComponent<Renderer>().material.color = Color.yellow;                
                int t = Int32.Parse(other.name);                
                string teste = palavra.Substring(t , 1);        
                if (objeto.ToLower().Contains(teste.ToLower())){
                    camera.GetComponent<cubos>().PalavraSubtrai(t);
                } 
            }
        }    
        GetComponent<Renderer>().material.color = Color.blue;
    }
}
