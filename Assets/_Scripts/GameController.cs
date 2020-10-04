using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    // references initiated to deal with the problem of text being in the camera hole
    public TMP_Text LivesLabel;
    public TMP_Text ScoresLabel;
   // public TMP_Text SceneLabel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (Input.deviceOrientation)
        {
            case DeviceOrientation.Portrait:
                //SceneLabel.text = "Portrait";
                LivesLabel.rectTransform.anchoredPosition = new Vector2(170.0f, -210.0f);
                ScoresLabel.rectTransform.anchoredPosition = new Vector2(-240.0f, -210.0f);
                break;
            case DeviceOrientation.LandscapeLeft:
                LivesLabel.rectTransform.anchoredPosition = new Vector2(300.0f, -100.0f);
                ScoresLabel.rectTransform.anchoredPosition = new Vector2(-250.0f, -100.0f);
                //SceneLabel.text = "LandscapeLeft";
                break;
            case DeviceOrientation.LandscapeRight:
                LivesLabel.rectTransform.anchoredPosition = new Vector2(160.0f, -100.0f);
                ScoresLabel.rectTransform.anchoredPosition = new Vector2(-385.0f, -100.0f);
                //SceneLabel.text = "LandscapeRight";
                break;
            case DeviceOrientation.Unknown:
                //SceneLabel.text = "Unknown";
                break;
        }
    }
}
