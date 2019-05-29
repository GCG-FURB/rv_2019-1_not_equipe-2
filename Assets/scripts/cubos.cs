using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    

public class cubos : MonoBehaviour
{                
    string palavra;
    // Start is called before the first frame update
    void Start()
    {        
        palavra = "CA";
        //int t = palavra->Length;
        Debug.Log(palavra.Length);

        for(int i = 0; i < palavra.Length ; i++){
            GameObject cubo = GameObject.CreatePrimitive(PrimitiveType.Plane); 
            cubo.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
            cubo.transform.rotation = Quaternion.Euler(-10, 0, 0);
            cubo.transform.position = new Vector3((i*7)-14, 0, 30f);
            cubo.name = i.ToString();
        }        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
