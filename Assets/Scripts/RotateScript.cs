using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateScript : MonoBehaviour
{
   
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Smoothly tilts a transform towards a target rotation.
        

        transform.Rotate(-200*(Vector3.up * Time.deltaTime), Space.World);
    }
}
