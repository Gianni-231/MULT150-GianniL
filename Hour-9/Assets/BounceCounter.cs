using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceCounter : MonoBehaviour
{   int bounces = 1;
    // Start is called before the first frame update
    void Start()
    {
    
    }

        void OnTriggerEnter (Collider other)
{
    print(other.gameObject.name + (bounces ++) + " times bounced");
}
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
