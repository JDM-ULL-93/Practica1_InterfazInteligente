using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ConsoleTest : MonoBehaviour
{

    private int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        List<GameObject> rootObjects = new List<GameObject>();
        Scene scene = SceneManager.GetActiveScene();
        scene.GetRootGameObjects(rootObjects);

        // iterate root objects and do something
        for (int i = 0; i < rootObjects.Count; ++i)
        {
            GameObject g = rootObjects[i];
            UnityEngine.Component[] comps = g.GetComponents(typeof(PropertiesTest));
            string msg = "Nombre : " + g.name;
            if (comps.Length > 0 )
            {
                PropertiesTest t = (PropertiesTest)comps[0];
                msg += " Id : " + t.Id;
            }
            msg += ". Valor contador = " + (++count); 
            UnityEngine.Debug.Log(msg);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
