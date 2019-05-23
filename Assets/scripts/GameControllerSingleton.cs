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
    }
}
