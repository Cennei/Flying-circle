using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Circle.Logic;

namespace Circle.Unit
{
    public class Obstacle : MonoBehaviour
    {
        public static GameObject player;

        void Start()
        {
            player = GameObject.FindGameObjectWithTag("Player");

        }
        void Update()
        {
            transform.position -= new Vector3(Time.deltaTime * StartGame.difficultyLVL * 3, 0, 0);// X axis player speed

        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.tag == "Border")
            {
                Destroy(this.gameObject);
            }

            else if (collision.tag == "Player")
            {
                GameOver.playerAlive = false;
                Destroy(this.gameObject);
            }
        }
    }
}