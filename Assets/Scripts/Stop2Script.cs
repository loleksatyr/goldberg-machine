using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stop2Script : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool stopped2 = false;
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
               stopped2 = true; 
                
        }
        
    }
}
