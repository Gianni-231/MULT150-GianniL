using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameracontrol : MonoBehaviour
{
    public GameObject camera;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       float hVal = Input.GetAxis("Horizontal");
float vVal = Input.GetAxis("Vertical");
if(hVal != 0)
    transform.Translate(hVal, 0, 0);
if(vVal != 0)
   transform.Translate(0, 0, vVal);

float mxVal = Input.GetAxis("Mouse X");
float myVal = Input.GetAxis("Mouse Y");
if(mxVal != 0)
    transform.Rotate(0, mxVal, 0);
if(myVal != 0)
     transform.Rotate(myVal, 0,0 );
    }
}
