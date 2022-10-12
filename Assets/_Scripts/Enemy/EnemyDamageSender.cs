using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamageSender : DamageSender
{
    public EnemyCtrl enemyCtrl;

    private void Awake()
    {
        enemyCtrl = GetComponent<EnemyCtrl>();
    }

    protected override void ColliderSendDamage(Collider2D col)
    {
        base.ColliderSendDamage(col);

        this.enemyCtrl.enemyDamageReceiver.Recieve(1);
    }
}
