using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    
void Start()
    {
      int x = TakeDamageFromFireball();
print ("Player health: " + x);


    }
int TakeDamageFromFireball()
{
    int playerHealth = 100;
    return playerHealth - 5;
}

int TakeDamageFromFireball(int damage)
{
    int playerHealth = 100;
    return playerHealth - damage;
    int y = TakeDamageFromFireball(25);
print ("Player health: " + y);
}

int TakeDamage(int damageAmount)
{
    int health = 100;
    return health - damageAmount;
}//takedamage is the method's name
  //it returns the remaining health after taking damage or an int
  // a Method is a block of code that performs a specific task. there are 2 parameters
   // the code in the method block is takedamage(int damageAmount)
    // Update is called once per frame
    // Update is called once per frame
    // Update is called once per frame
    int TakeDamageFromFireball(int damage, int playerHealth)
{
    return playerHealth - damage;
    int z = TakeDamageFromFireball(30, 50);
print ("Player health: " + z);
}
 
    void Update()
    {
        
    }
}
