using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Circle.Logic
{
    public class SpawnObstacles : MonoBehaviour
    {
        [SerializeField] GameObject obstacle;
        [SerializeField] float maxY;
        [SerializeField] float minY;
        [SerializeField] float timeBetweenSpawn;

        private float spawnTime;

        void Update()
        {
            spawnTime += Time.deltaTime;
            if (spawnTime > timeBetweenSpawn / StartGame.difficultyLVL)
            {
                Spawn();
                spawnTime = 0;
            }
        }

        void Spawn()
        {
            float randomY = Random.Range(minY, maxY);

            Instantiate(obstacle, transform.position + new Vector3(0, randomY, 0), transform.rotation, transform.parent);

        }


    }
}