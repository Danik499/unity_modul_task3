using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineScript : MonoBehaviour
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
        Storage.message = "Don't step on the red line!";
        player.transform.position = new Vector3(11, 0.71f, 0);
    }
}
