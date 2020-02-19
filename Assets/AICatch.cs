using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.AI; 

public class AICatch : MonoBehaviour
{
    public GameObject destination; 
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<NavMeshAgent>().SetDestination(destination.transform.position); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
