using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Palavras;
// The following code example enumerates the elements of a OrderedDictionary.
using System.Collections.Specialized;
public class setup : MonoBehaviour
{

    public GameObject current;


    // Start is called before the first frame update
    void Start()
    {
        IDictionaryEnumerator e = Palavras.niveis.GetEnumerator();
        e.MoveNext();
        //Texture3D texture = (Texture3D) Resources.Load ("Resources/clouds1024");
        //current.GetComponent<Renderer>().material.mainTexture = texture;
        Debug.Log(e.Key.ToString());
        GameObject instance = Instantiate(Resources.Load(e.Key.ToString(), typeof(GameObject))) as GameObject;
        instance.transform.position = new Vector3(10, 5, 15);
        instance.transform.rotation = new Quaternion(20, 0, 0, 0);
        instance.transform.localScale = new Vector3(20, 20, 20);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
