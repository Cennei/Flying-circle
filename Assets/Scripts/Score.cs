using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Circle.Logic;

namespace Circle.Score
{

    public class Score : MonoBehaviour
    {
        [SerializeField] Text scoreText;

        public static float score;

        void Update()
        {
            if (GameObject.FindGameObjectWithTag("Player") != null)
            {
                score += 1 * Time.deltaTime;
                scoreText.text = ((int)score).ToString();
            }
        }

    }
}