using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FPSDisplay : MonoBehaviour {

    public Text highestFPSLabel, averageFPSLabel, lowestFPSLabel;
    FPSCounter fpsCounter;
	// Use this for initialization
	void Start () {
		
	}

    private void Awake()
    {

       fpsCounter = GetComponent<FPSCounter>();

    }

    // Update is called once per frame
    void Update () {
       // fpsLabel.text = fpsCounter.FPS.ToString();
       // fpsLabel.text = Mathf.Clamp(fpsCounter.FPS, 0, 99).ToString();

        highestFPSLabel.text = Mathf.Clamp(fpsCounter.HighestFPS, 0, 99).ToString();
        averageFPSLabel.text = Mathf.Clamp(fpsCounter.AverageFPS, 0, 99).ToString();
        lowestFPSLabel.text = Mathf.Clamp(fpsCounter.LowestFPS, 0, 99).ToString();
    }
}
