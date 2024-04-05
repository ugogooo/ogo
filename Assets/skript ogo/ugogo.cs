using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ugogo : MonoBehaviour
{
    public float speed = 20.5f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate( Vector3.forward*Time.deltaTime*speed);
        
    }
}
