using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI resatartText;

    public GameObject quitButton;

    void Start()
    {
        if (resatartText == null)
            Debug.LogError("restart Text is null");

        if (scoreText == null)
            Debug.LogError("score Text is null");

        if (quitButton == null)
            Debug.LogError("Quit Button is null");

        resatartText.gameObject.SetActive(false);
        quitButton.SetActive(false);
    }

    public void SetRestart()
    {
        resatartText.gameObject.SetActive(true);
        quitButton.SetActive(true);
    }

    public void UpdateScore(int score)
    {
        scoreText.text = score.ToString();
    }
}

