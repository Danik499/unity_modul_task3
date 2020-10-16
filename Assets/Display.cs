using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Display : MonoBehaviour
{
    public Text score;
    public Text lineMessage;
    
    void Start()
    {
        
    }

 
    void Update()
    {
        score.text = "Score :" + Storage.score.ToString();
        lineMessage.text = Storage.message;
    }
}
