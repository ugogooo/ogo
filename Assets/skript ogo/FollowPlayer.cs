using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 7, 30);
    void Start()
    {
        
    }

    // Update is called once per frame
    void  LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
