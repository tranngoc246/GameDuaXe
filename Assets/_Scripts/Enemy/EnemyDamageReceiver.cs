using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamageReceiver : DamageReceiver
{
    protected EnemyCtrl enemyCtrl;

    private void Reset()
    {
        this.HP = 3;
    }

    private void Awake()
    {
        enemyCtrl = GetComponent<EnemyCtrl>();
    }

    public override void Recieve(int damage)
    {
        base.Recieve(damage);

        if (IsDead())
        {
            EffectManager.Ins.SpawnVFX("Explosion_A", transform.position, transform.rotation);
            enemyCtrl.despawner.Despawn();
        }
    }

}
