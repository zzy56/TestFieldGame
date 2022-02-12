using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public GameObject gameObj;
    public bool despwawnWhenInvisible = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnBecameInvisible()
    {
        if (despwawnWhenInvisible)
        {
            Destroy(gameObj);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
