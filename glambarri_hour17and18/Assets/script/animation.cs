using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animation : MonoBehaviour
{
    Animator animator;
    
    // Use this for initialization
    void Start () {
        animator = GetComponent<Animator>();
    }
    
    // Update is called once per frame
    void Update () {
        
      if (Input.GetKeyDown(KeyCode.W))
        {
            animator.SetTrigger("color");
           
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            animator.SetTrigger("rotate");
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            animator.SetTrigger("hover");
        }
    }

    
    
}
