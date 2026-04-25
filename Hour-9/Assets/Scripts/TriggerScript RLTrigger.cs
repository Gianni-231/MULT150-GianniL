using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScriptRLTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

     void OnTriggerEnter(Collider other)
    {
        if (other.name == "LTrigger" || other.name == "RTrigger")
        {
            Debug.Log("Entered trigger: " + other.name);
        }
    }

     void OnTriggerStay(Collider other)
    {
        if (other.name == "LTrigger" || other.name == "RTrigger")
        {
            Debug.Log("Staying in trigger: " + other.name);
        }
    }

     void OnTriggerExit(Collider other)
    {
        if (other.name == "LTrigger" || other.name == "RTrigger")
        {
            Debug.Log("Exited trigger: " + other.name);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
