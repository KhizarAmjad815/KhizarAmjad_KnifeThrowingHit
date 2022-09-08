using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager;
    public static int score = 0;
    public TMP_Text scoreText;
    public static bool isGameOver = false;

    private void Awake()
    {
        if (gameManager == null)
        {
            gameManager = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void UpdateScore()
    {
        if (score == 9)
        {
            scoreText.text = "You WON!";
            isGameOver = true;
        }
        else if (!isGameOver)
        {
            scoreText.text = "Score:" + score.ToString();
        }
        else
        {
            scoreText.text = "Game Over!";
        }
    }
}
