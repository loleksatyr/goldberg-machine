using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.SceneManagement;

public class SphereScript : MonoBehaviour
{
     Rigidbody rigibody;
     public float overallSpeed;
      public float thrust1;
      public float thrust2;
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
            Debug.Log(overallSpeed);
            //rigibody.velocity.magnitude = 2*(rigibody.velocity.magnitude);
            rigibody.AddForce(thrust1, 0, thrust2, ForceMode.Impulse);
        }
        if(StopScript.stopped == true){
            Debug.Log(overallSpeed);
            //rigibody.velocity.magnitude = 2*(rigibody.velocity.magnitude);
            rigibody.AddForce(-thrust1, 0,-thrust2, ForceMode.Impulse);
        }
         if(SpeedScript.speed == true){
            Debug.Log(overallSpeed);
            //rigibody.velocity.magnitude = 2*(rigibody.velocity.magnitude);
            rigibody.AddForce(2*thrust1, 0,0, ForceMode.Impulse);
        }
       
         if(Stop2Script.stopped2 == true){
            Debug.Log(overallSpeed);
            //rigibody.velocity.magnitude = 2*(rigibody.velocity.magnitude);
            
            rigibody.AddForce(-thrust1/2, 0, 0, ForceMode.Impulse);
        }
         if(PermaStopScript.stoppeds == true){
            Debug.Log("Stop");
            //rigibody.velocity.magnitude = 2*(rigibody.velocity.magnitude);
            horizontalVelocity = new Vector3(0, rigibody.velocity.y, 0);
            rigibody.velocity = horizontalVelocity;      
             transform.position = new Vector3(0,4,0);
  

        }
    }
}
