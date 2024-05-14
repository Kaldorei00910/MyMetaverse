using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    Text timerObject;
    // Start is called before the first frame update
    void Start()
    {
        timerObject = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        WhatTime();
    }
    public void WhatTime()
    { 
        timerObject.text = DateTime.Now.ToString("HH:mm");


    }
}
