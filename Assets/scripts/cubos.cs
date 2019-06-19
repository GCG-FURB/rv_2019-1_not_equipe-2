using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    

public class cubos : MonoBehaviour
{                

    public GameObject lista;


    List<GameObject> planos = new List<GameObject>();
    public int[] vpalavra = new int[8];
    string palavra;
    // Start is called before the first frame update
    void Start()
    {        
        GameControllerSingleton.Instance.nextLevel();
        palavra =  GameControllerSingleton.Instance.getCurrentWord();
        //Debug.Log(palavra.Length);
        for (int i = 0; i < 10; i++){
            vpalavra[i] = 0;
        } 

        CriaPlanos();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PalavraSoma(int i){
        vpalavra[i] = 1;
    }

    public void PalavraSubtrai(int i){
        vpalavra[i] = 0;
    }

    public void CriaPlanos(){
        palavra =  GameControllerSingleton.Instance.getCurrentWord();
        for(int i = 0; i < palavra.Length ; i++){
            GameObject cubo = GameObject.CreatePrimitive(PrimitiveType.Plane);
            planos.Add(cubo); 
            cubo.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
            cubo.transform.rotation = Quaternion.Euler(-10, 0, 0);
            cubo.transform.position = new Vector3((i*7)-10, 0, 30f);
            cubo.name = i.ToString();
        } 
    }

    public void DestroiPlanos(){        
         foreach (GameObject g in planos)
        {
            Destroy(g);
        }       
    }

    public bool verificapalavra(){
        bool palavracerta = true;
        for (int i = 0; i < palavra.Length; i++){
            if(vpalavra[i] == 0){
                palavracerta = false;
            }
        }
        return palavracerta;
    }

    public void zeravpalavra(){
        for (int i = 0; i < 10; i++){
            vpalavra[i] = 0;
        } 
    }
}
