using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    /*public GameObject minionPrefab;
    public float spawnDelay;

    List<GameObject> minions;
    float spawnTime;

    void Start()
    {
        minions = new List<GameObject>();
    }

    void Update()
    {
        Spawn();
        CheckMinionDead();
    }

    void Spawn()
    {
        spawnTime += Time.deltaTime;
        if (spawnTime < spawnDelay) return;
        spawnTime = 0;

        if (minions.Count >= 7) return;

        float posX = Random.Range(-10, 11);
        float posY = Random.Range(-4, 5);
        GameObject minion = Instantiate(minionPrefab, new Vector2(posX,posY),Quaternion.identity);
        minion.name = "Boom";
        this.minions.Add(minion);
    }

    void CheckMinionDead()
    {
        for(int i = 0; i < this.minions.Count; i++)
        {
            if (this.minions[i] == null)
            {
                this.minions.RemoveAt(i);
            }
        }
    }*/
}
