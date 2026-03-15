using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       float health = 1004f; 
       float PoisonDamage = 125.5f;
       health -= PoisonDamage;
       health -= PoisonDamage;
       health -= PoisonDamage;
       health -= PoisonDamage;
      health -= PoisonDamage;
        health -= PoisonDamage;
          health -= PoisonDamage;
            health -= PoisonDamage;
      Debug.Log(health);
      
      
 }

    // Update is called once per frame
    void Update()
    {
        
    }
}
