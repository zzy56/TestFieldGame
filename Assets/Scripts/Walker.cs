using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walker : MonoBehaviour
{

    public Vector3 speed = new Vector3(-0.01f, 0);

    [SerializeField]
    private GameObject walkingGameObject;

    private void Awake()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = walkingGameObject.transform.position + speed * Time.deltaTime;

        Vector3 localScale = walkingGameObject.transform.localScale;
        if (speed.x > 0)
        {
            localScale.x = -1;
        }
        else
            localScale.x = 1;

        walkingGameObject.transform.localScale = localScale;

        walkingGameObject.transform.position = newPos;

    }

    
    


}
