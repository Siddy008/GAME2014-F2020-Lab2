﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButtonBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Event Handler for the ResrartButtonPressed Event
    public void OnRestartButtonPressed()
    {
        Debug.Log(message: "Restart Button pressed!");
        SceneManager.LoadScene("Play");
    }
}
