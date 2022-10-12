using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamageReceiver : DamageReceiver
{
    protected PlayerCtrl playerCrtl;

    private void Awake()
    {
        playerCrtl = GetComponent<PlayerCtrl>();
    }

    public override void Recieve(int damage)
    {
        base.Recieve(damage);
        if (this.IsDead())
        {
            this.playerCrtl.playerStatus.Dead();
            UIManager.Ins.btnGameOver.SetActive(true);

        }
    }
}
