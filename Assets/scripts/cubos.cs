using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    

public class cubos : MonoBehaviour
{                

    public GameObject lista;


    List<GameObject> planos = new List<GameObject>();

    public int contpalavra = 0;
    string palavra;
    // Start is called before the first frame update
    void Start()
    {        
        GameControllerSingleton.Instance.nextLevel();
        palavra =  GameControllerSingleton.Instance.getCurrentWord();
        //Debug.Log(palavra.Length);

        CriaPlanos();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PalavraSoma(){
        contpalavra++;
    }

    public void PalavraSubtrai(){
        contpalavra--;
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
}
