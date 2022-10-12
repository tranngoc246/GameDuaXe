using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombSpawner : Spawner
{
    private void Reset()
    {
        this.prefabName = "BombPrefab";
        this.spawnPosName = "BombSpawnPos";
        this.maxObj = 7;
    }
}
