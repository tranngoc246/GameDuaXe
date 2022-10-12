using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeSpawner : MonoBehaviour
{
    private void Update()
    {
        if (PlayerCtrl.Ins.damageReceiver.IsDead())
        {
            Destroy(gameObject);
        }
    }
    public virtual void Despawn()
    {
        Destroy(gameObject);
    }
}
