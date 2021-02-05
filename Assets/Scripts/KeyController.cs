﻿using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class KeyController : MonoBehaviour
{
    

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            LevelManager.instance.hasKey = true;
            Destroy(this);
            
        }

    }

}
