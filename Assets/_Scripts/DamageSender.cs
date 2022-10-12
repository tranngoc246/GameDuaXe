using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageSender : MonoBehaviour
{
    [Header("DamageSender")]
    public int damage = 1;

    private void OnTriggerEnter2D(Collider2D col)
    {
        this.ColliderSendDamage(col);
    }

    protected virtual void ColliderSendDamage(Collider2D col)
    {
        DamageReceiver damageReciever = col.GetComponent<DamageReceiver>();
        if (damageReciever == null) return;
        damageReciever.Recieve(this.damage);
    }
}
