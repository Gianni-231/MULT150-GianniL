using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TIYEthan : MonoBehaviour
{
    Animator ethancontroller;
void Start ()
{
    // Get a reference to the animator
     ethancontroller = GetComponent<Animator> ();
}
void Update ()
{
     ethancontroller.SetFloat ("Speed", Input.GetAxis ("Vertical"));
    ethancontroller.SetFloat ("Direction", Input.GetAxis("Horizontal"));
}
}
