﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//-////////////////////////////////////////////////////
///
/// Check Points is used to trigger events when the player comes into contact with a check point, such as updating spawning position. It requires to add the
/// GameManager scene object into the checkpoint on the scene in order for checkPoint to work
///
public class CheckPoint : MonoBehaviour 
{
    public GameManager gameManager;
   
    //-////////////////////////////////////////////////////
    ///
    /// When the player touches a check point, it updates the spawn position for the player
    ///
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            gameManager.UpdateSpawnPosition(gameObject.transform);
        }
    }
}
