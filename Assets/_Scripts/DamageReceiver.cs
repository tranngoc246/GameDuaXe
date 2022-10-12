using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageReceiver : MonoBehaviour
{
    [Header("DamageReciever")]
    public int HP = 1;

    public virtual bool IsDead()
    {
        return this.HP <= 0;
    }

    public virtual void Recieve(int damage)
    {
        HP -= damage;
    }
}
