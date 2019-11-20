using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BordersScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var spherec = GetComponent<Renderer>();
        spherec.material.SetColor("_Color",Color.blue);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
