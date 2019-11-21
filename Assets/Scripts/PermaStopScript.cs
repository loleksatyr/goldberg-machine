using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PermaStopScript : MonoBehaviour
{
    // Start is called before the first frame update
     public static bool stoppeds = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("point");
        ContactPoint contact = collision.contacts[0];
        Debug.Log(collision.gameObject.name);
        if(collision.gameObject.name=="Sphere"){
               stoppeds = true; 
                
        }
        
    }
}
