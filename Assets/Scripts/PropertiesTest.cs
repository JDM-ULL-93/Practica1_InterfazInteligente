using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropertiesTest : MonoBehaviour
{
    private static int count = 0;
    private int id;

    public int Id { get => id; /*set => id = value;*/ }

    // Start is called before the first frame update
    void Start()
    {
        id = count + 1;
        count++;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
