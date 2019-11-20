using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateScript : MonoBehaviour
{
   
    public static bool touched = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Smoothly tilts a transform towards a target rotation.
        

        transform.Rotate(-210*(Vector3.up * Time.deltaTime), Space.World);
    }
     void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("point");
        ContactPoint contact = collision.contacts[0];
        Debug.Log(collision.gameObject.name);
        if(collision.gameObject.name=="Sphere"){
               touched = true; 
                
        }
        
    }
}
