using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class TestButtonBehaviour : MonoBehaviour
{
    // public TMP_Text SceneLabel;
    public TMP_Text LivesLabel;
    public TMP_Text ScoresLabel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Event Handler for the TestButtonPressed Event
    public void OnTestButtonPressed()
    {
        Debug.Log(message: "Test Button pressed!");

        //this changes the test to "Test" once the button is pressed
        //SceneLabel.text = "Test";
        LivesLabel.rectTransform.anchoredPosition = new Vector2(300.0f, -100.0f);
        ScoresLabel.rectTransform.anchoredPosition = new Vector2(-250.0f, -100.0f);
    }
}
