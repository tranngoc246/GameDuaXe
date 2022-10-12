using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombDamageReceiver : DamageReceiver
{
    public override void Recieve(int damage)
    {
        base.Recieve(damage);

        if (IsDead())
        {
            Destroy(gameObject);
            EffectManager.Ins.SpawnVFX("Explosion_B", transform.position, transform.rotation);
        }
    }

}
