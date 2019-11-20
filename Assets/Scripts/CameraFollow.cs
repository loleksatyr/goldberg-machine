using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
  public Transform Spherefollow;
  private Vector3 _cameraOffset;
  [Range(0.01f,1.0f)]
  public float SmoothFactor= 0.5f;
  public bool lksp;
    void Start()
    {
        _cameraOffset = transform.position - Spherefollow.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 newPos = Spherefollow.position + _cameraOffset; 
        transform.position = Vector3.Slerp(transform.position,newPos,SmoothFactor);
    if(lksp){
        transform.LookAt(Spherefollow);
    }
    }
}
