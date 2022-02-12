using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject spawningObj;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 3.0f, 3.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawn()
    {
        Instantiate(spawningObj, transform);
    }
}
