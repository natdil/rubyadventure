﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NonPlayerCharacter : MonoBehaviour
{
    public float displayTime = 4.0f;
    public GameObject dialogBox;
    float timerDisplay;
    void Start()
    {
    dialogBox.SetActive(false);
    timerDisplay = -1.0f;
}
    // Update is called once per frame
    void Update()
    {
        
    }
}
