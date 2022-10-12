using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCtrl : MonoBehaviour
{
    public DeSpawner despawner;
    public EnemyDamageReceiver enemyDamageReceiver;

    private void Awake()
    {
        despawner = GetComponent<DeSpawner>();
        enemyDamageReceiver = GetComponent<EnemyDamageReceiver>();
    }
}
