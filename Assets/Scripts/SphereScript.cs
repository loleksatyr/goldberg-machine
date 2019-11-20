using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereScript : MonoBehaviour
{
     Rigidbody rigibody;
     public float overallSpeed;
    void Start()
    {
        var spherec = GetComponent<Renderer>();
        spherec.material.SetColor("_Color",Color.red);
        rigibody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
         Vector3 horizontalVelocity = rigibody.velocity;
        horizontalVelocity = new Vector3(rigibody.velocity.x, 0, rigibody.velocity.z);

        // The speed on the x-z plane ignoring any speed
        float horizontalSpeed = horizontalVelocity.magnitude;
        // The speed from gravity or jumping
        float verticalSpeed  = rigibody.velocity.y;
        // The overall speed
        overallSpeed = rigibody.velocity.magnitude;
        //Debug.Log(overallSpeed);
        if(RotateScript.touched == true){
            Debug.Log("aaa");
            //rigibody.velocity.magnitude = 2*(rigibody.velocity.magnitude);
        }
    }
}
