using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Circle.Unit;

namespace Circle.Logic
{
    public class LoppingScript : MonoBehaviour
    {
        private static float backgroundSpeed;
        [SerializeField] Renderer backgroundRenderer;

        void Start()
        {

            Obstacle.player = GameObject.FindGameObjectWithTag("Player");
        }

        void Update()
        {
            backgroundSpeed = StartGame.difficultyLVL * 3;
            backgroundRenderer.material.mainTextureOffset += new Vector2(backgroundSpeed * Time.deltaTime, 0f);

        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.tag == "Player")
            {
                GameOver.playerAlive = false;
            }
        }
    }
}