using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereScript : MonoBehaviour
{
    
    void Start()
    {
        var spherec = GetComponent<Renderer>();
        spherec.material.SetColor("_Color",Color.red);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
