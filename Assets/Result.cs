using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Result : MonoBehaviour
{
    public GameObject player;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Storage.score = -collision.transform.position.x;
        player.transform.position = new Vector3(11, 0.71f, 0);
    }
}
