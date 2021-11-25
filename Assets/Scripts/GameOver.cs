using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Circle.Score;
using Circle.Unit;

namespace Circle.Logic
{
    public class GameOver : MonoBehaviour
    {
        [SerializeField] GameObject gameOverPanel;
        [SerializeField] GameObject level;
        [SerializeField] Text triesText;

        public static int countOfTries;
        public static bool playerAlive = true;

        void Update()
        {
            if (playerAlive == false)
            {
                playerAlive = true;

                gameOverPanel.SetActive(true);
                level.SetActive(false);

                triesText.text = ((int)countOfTries).ToString();
            }
        }

        public void Restart()
        {
            countOfTries += 1;
            Score.Score.score = 0;

            level.SetActive(true);
            gameOverPanel.SetActive(false);

            StartGame.difficultyLVL = StartGame.currentDifficulty;
    }

    }
}