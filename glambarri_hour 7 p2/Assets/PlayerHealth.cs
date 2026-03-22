using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {  
        float dead = 0f;
       float health = 1004f; 
       float PoisonDamage = 125.5f;
       while (health >= 0)
{
    health -= PoisonDamage;
}

Debug.Log(dead);
      
      
 }

    // Update is called once per frame
    void Update()
    {
        
    }
}