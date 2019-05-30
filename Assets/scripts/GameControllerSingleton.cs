using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class GameControllerSingleton : Singleton<GameControllerSingleton>
{
    public int currentLevel = 0;
    public string MyTestString = "Hello world!";

    public GameObject instance;
    public void nextLevel(){ 
        currentLevel++;
         
         var keyValuePair = Palavras.niveis.Where(p => p.Value == currentLevel).First();
         Debug.Log(keyValuePair.Value);

        Destroy(instance);
        instance = Instantiate(Resources.Load(keyValuePair.Key.ToString(), typeof(GameObject))) as GameObject;
        instance.transform.position = new Vector3(10, 5, 15);
		instance.transform.rotation = new Quaternion(0, 0, 0, 0);	
        instance.transform.localScale = new Vector3(20, 20, 20);		

		if(keyValuePair.Key.ToString().Equals("rua")){
			instance.transform.rotation = new Quaternion(180, 0, 0, 0);
		} 
		if (keyValuePair.Key.ToString().Equals("ovo")){
			instance.transform.rotation = new Quaternion(0, 50, -30, 0);	
		}        
		if (keyValuePair.Key.ToString().Equals("casa")){
			instance.transform.rotation = new Quaternion(0, 150, 0, 0);	
			instance.transform.localScale = new Vector3(1, 1, 1);
			instance.transform.position = new Vector3(10, 3, 15);
		}
		if (keyValuePair.Key.ToString().Equals("doce")){
			instance.transform.localScale = new Vector3(10, 10, 10);
		}
		if (keyValuePair.Key.ToString().Equals("piano")){
			instance.transform.position = new Vector3(10, (float)2.7, 15);
			instance.transform.rotation = new Quaternion(0, 180, 150, 0);	
			instance.transform.localScale = new Vector3((float)0.2, (float)0.2, (float)0.2);
		}
		if (keyValuePair.Key.ToString().Equals("garfo")){
			instance.transform.rotation = new Quaternion(0, 100, 100, 0);	
			instance.transform.localScale = new Vector3(30, 30, 30);
		}
		if (keyValuePair.Key.ToString().Equals("macaco")){
			instance.transform.position = new Vector3(10, 1, 15);
			instance.transform.rotation = new Quaternion(0, 180, 0, 0);
			instance.transform.localScale = new Vector3(2, 2, 2);
		}
    }

    public String getCurrentWord(){
         var keyValuePair = Palavras.niveis.Where(p => p.Value == currentLevel).First();
         return keyValuePair.Key.ToString();
    }
}
