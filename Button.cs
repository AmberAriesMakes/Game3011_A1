using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    public GameObject gameCanvas, goCanvas;
    public bool gcActive, ScanMode, ExtractMode;
    public int Scans, Extractions, Score;
    public Text buttonText, scansText, extractText, scoreText, finalScoreText;
    public float Delay = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
        Scans = 5;
        Extractions = 3;
        ScanMode = false;
        ExtractMode = true;
        gcActive = false;
    }

    // Update is called once per frame
    void Update()
    {
        scansText.text = "Scans Remaining: " + Scans;
        extractText.text = "Extractions Remaining: " + Extractions;
        scoreText.text = "Score: " + Score;
        finalScoreText.text = "Final Score: " + Score;


        if (gameCanvas != null)
        {
            if (gcActive)
            {
                gameCanvas.SetActive(true);
            }
            else
            {
                gameCanvas.SetActive(false);
            }

        }

        if (ExtractMode)
        {
            buttonText.text = "Extract Mode";
        }

        if (ScanMode)
        {
            buttonText.text = "Scan Mode";
        }
        if (Extractions == 0)
        {
            Delay -= Time.deltaTime;
            if (Delay < 0)
            {
                if (gameCanvas != null)
                    gameCanvas.SetActive(false);
                if (goCanvas != null)
                    goCanvas.SetActive(true);
            }
        }
    }

    public void changeMode()
    {
        ScanMode = !ScanMode;
        ExtractMode = !ExtractMode;
    }

    public void closeScreen()
    {
        Destroy(goCanvas.gameObject);
        Destroy(gameCanvas.gameObject);
        gcActive = false;

    }

}
