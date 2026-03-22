using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Birthday : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    
        int month = 1;
        int days = 1;
       while (month >= 31)
{
    month += days;
}

        
        if ( month == 27 )
{
     Debug.Log("Happy Birthday!");
}
else
{
    Debug.Log(month);
} 
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
