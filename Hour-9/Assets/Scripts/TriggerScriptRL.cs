using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScriptRL : MonoBehaviour
{
    private GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("sphere"); 
    }
 void OnTriggerEnter(Collider other)
{
    if (GameObject.Find("sphere") == target)
    {
        Debug.Log("Entered trigger: " + gameObject.name);
    }
}

 void OnTriggerStay(Collider other)
{
    if (GameObject.Find("sphere") == target)
    {
        Debug.Log("Staying in trigger: " + gameObject.name);
    }
}

 void OnTriggerExit(Collider other)
{
    if (GameObject.Find("sphere") == target) // or whatever your sphere is tagged
    {
        Debug.Log("Exited trigger: " + gameObject.name);
    }
}
    // Update is called once per frame
    void Update()
    {
        
    }
}
