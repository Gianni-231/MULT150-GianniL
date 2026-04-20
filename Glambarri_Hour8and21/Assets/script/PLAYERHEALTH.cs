using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLAYERHEALTH : MonoBehaviour
{    int health = 3992; 
    // Start is called before the first frame update
    void Start()
    {
        
    health = UsePotion(health);
     health = UsePotion(health);
      health = UsePotion(health);
     Debug.Log("After Potion: " + health);
    }  

  int UsePotion(int Healthpoint)
{
    int healAmount = 400;
    return Healthpoint + healAmount;
}

    // Update is called once per frame
    void Update()
    {
      
    }
}
