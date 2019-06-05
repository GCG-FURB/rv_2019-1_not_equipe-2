using System;
using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class GameControllerSingleton : Singleton<GameControllerSingleton>
{
    public int currentLevel = 0;
    public string MyTestString = "Hello world!";
    //public Image img;

    public GameObject instance;
    public void nextLevel()
    {
        currentLevel++;

        var keyValuePair = Palavras.niveis.Where(p => p.Value == currentLevel).First();
        Debug.Log(keyValuePair.Value);

        Destroy(instance);
        instance = Instantiate(Resources.Load(keyValuePair.Key.ToString(), typeof(GameObject))) as GameObject;
        instance.transform.position = new Vector3(10, 5, 15);
        instance.transform.rotation = new Quaternion(0, 0, 0, 0);
        instance.transform.localScale = new Vector3(20, 20, 20);

        if (keyValuePair.Key.ToString().Equals("rua"))
        {
            instance.transform.rotation = new Quaternion(180, 0, 0, 0);
        }
        if (keyValuePair.Key.ToString().Equals("ovo"))
        {
            instance.transform.rotation = new Quaternion(0, 50, -30, 0);
        }
        if (keyValuePair.Key.ToString().Equals("casa"))
        {
            instance.transform.rotation = new Quaternion(0, 150, 0, 0);
            instance.transform.localScale = new Vector3(1, 1, 1);
            instance.transform.position = new Vector3(10, 3, 15);
        }
        if (keyValuePair.Key.ToString().Equals("doce"))
        {
            instance.transform.localScale = new Vector3(10, 10, 10);
        }
        if (keyValuePair.Key.ToString().Equals("piano"))
        {
            instance.transform.position = new Vector3(10, (float)2.7, 15);
            instance.transform.rotation = new Quaternion(0, 180, 150, 0);
            instance.transform.localScale = new Vector3((float)0.2, (float)0.2, (float)0.2);
        }
        if (keyValuePair.Key.ToString().Equals("garfo"))
        {
            instance.transform.rotation = new Quaternion(0, 100, 100, 0);
            instance.transform.localScale = new Vector3(30, 30, 30);
        }
        if (keyValuePair.Key.ToString().Equals("macaco"))
        {
            instance.transform.position = new Vector3(10, 1, 15);
            instance.transform.rotation = new Quaternion(0, 180, 0, 0);
            instance.transform.localScale = new Vector3(2, 2, 2);
        }
        if (keyValuePair.Key.ToString().Equals("abacate"))
        {
            instance.transform.rotation = new Quaternion(0, 50, -30, 0);
        }
        if (keyValuePair.Key.ToString().Equals("uva"))
        {
            instance.transform.localScale = new Vector3(10, 10, 10);
        }
        if (keyValuePair.Key.ToString().Equals("frio"))
        {
            instance.transform.position = new Vector3(11, 3, 15);
            instance.transform.localScale = new Vector3(2, 2, 2);
            instance.transform.rotation = new Quaternion(0, 180, 0, 0);
        }
        if (keyValuePair.Key.ToString().Equals("cadeira"))
        {
            instance.transform.localScale = new Vector3(4, 4, 4);
            instance.transform.rotation = new Quaternion(0, 180, 0, 0);
            instance.transform.position = new Vector3(10, 3, 15);
        }

         StartCoroutine(move());

    }

    public String getCurrentWord()
    {
        var keyValuePair = Palavras.niveis.Where(p => p.Value == currentLevel).First();
        return keyValuePair.Key.ToString();
    }


    public float smoothTime = 0.3F;
    private Vector3 velocity = Vector3.zero;


     IEnumerator move()
    {

        if (currentLevel > 1)
        {

			var original = instance.transform.position;
			var tamOriginal = instance.transform.localScale;
			for(float i = 0; i <= 1; i += 0.1f){

				var meio = new Vector3(1.5f, 1.5f, 15);

				//Vector3 targetPosition = instance.transform.TransformPoint(new Vector3(0, 5, -10));
				Debug.Log("transformed");
				instance.transform.position = Vector3.Lerp(original, meio, i);
				 //instance.transform.localScale = Vector3.Lerp(tamOriginal, Vector3.Scale(tamOriginal, new Vector3(tamOriginal.x * 0.1f, tamOriginal.y * 0.1f, tamOriginal.z)), i);
				 instance.transform.localScale = Vector3.Lerp(tamOriginal, new Vector3(tamOriginal.x * 2.5f, tamOriginal.y * 2.5f, tamOriginal.z * 2.5f), i);
				yield return new WaitForSeconds(0.1f);
			}
			
			for(float i = 1; i >= 0; i -= 0.1f){

				var meio = new Vector3(1.5f, 1.5f, 15);

				//Vector3 targetPosition = instance.transform.TransformPoint(new Vector3(0, 5, -10));
				Debug.Log("transformed");
				instance.transform.position = Vector3.Lerp(original, meio, i);
				instance.transform.localScale = Vector3.Lerp(tamOriginal, new Vector3(tamOriginal.x * 2.5f, tamOriginal.y * 2.5f, tamOriginal.z * 2.5f), i);
				//instance.transform.localScale = Vector3.Lerp(tamOriginal, Vector3.Scale(tamOriginal, new Vector3(tamOriginal.x * 0.1f, tamOriginal.y * 0.1f, tamOriginal.z)), i);
				yield return new WaitForSeconds(0.1f);
			}


        }
    }
    void FadeImage(bool fadeAway)
    {

        /**
                // fade from opaque to transparent
                if (fadeAway)
                {
                    // loop over 1 second backwards
                    for (float i = 1; i >= 0; i -= Time.deltaTime)
                    {
                //        instance.transform.rotation = new Quaternion(0, i, 0, 0);
              //          img.color = new Color(1, 1, 1, i);
                        Debug.Log("yeld");
                       yield return null;
                    }
                }
                // fade from transparent to opaque
                else
                {
                    // loop over 1 second
                    for (float i = 0; i <= 1; i += Time.deltaTime)
                    {
                        // set color with i as alpha
                    //	instance.transform.rotation = new Quaternion(0, i, 0, 0);
                //        img.color = new Color(1, 1, 1, i);
                Debug.Log("yeld2");
                        yield return null;
                    }
                }
                 */
    }

}
