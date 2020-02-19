﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillGame : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player; 

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(other.gameObject);
        }

        if(other.gameObject.tag == "AI")
        {
            Destroy(player.gameObject); 
        }

    }
}
