using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : Spawner
{
    private void Reset()
    {
        this.prefabName = "EnemyPrefab";
        this.spawnPosName = "EnemySpawnPos";
        this.maxObj = 1;
    }
}
