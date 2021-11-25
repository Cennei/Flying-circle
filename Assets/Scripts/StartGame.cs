using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Circle.Logic
{
    public class StartGame : MonoBehaviour
    {
        [SerializeField] GameObject playerObj;

        [SerializeField] Slider difficulty;

        public static float difficultyLVL;
        public static float currentDifficulty;

        private float timeSinceStart;
        void Awake()
        {
            DifficultyCount(difficulty);
        }

        private void Update()
        {
            timeSinceStart += Time.deltaTime;
            if (timeSinceStart > 15)
            {
                difficultyLVL += 1;
                timeSinceStart = 0;
            }
        }

        public void PlacePlayer()
        {
            Instantiate(playerObj, new Vector3(-5, 0, 0), Quaternion.identity, transform.parent);
        }


        public void DifficultyCount(Slider dif)
        {

            difficultyLVL = difficulty.value;
            currentDifficulty = difficulty.value;
        }
    }
}