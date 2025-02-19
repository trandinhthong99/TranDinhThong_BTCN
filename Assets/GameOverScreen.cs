﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public Text pointsText;
    public GameObject pauseButton;
    public void Setup(int score)
    {
        gameObject.SetActive(true);
        pauseButton.SetActive(false);
        pointsText.text = score.ToString() + " POINTS";
    }

    public void RestartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void ExitButton()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
