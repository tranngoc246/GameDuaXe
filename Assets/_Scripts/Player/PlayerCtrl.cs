using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    public static PlayerCtrl Ins;
    public DamageReceiver damageReceiver;
    public PlayerStatus playerStatus;

    private void Awake()
    {
        Ins = this;
        damageReceiver = GetComponent<DamageReceiver>();
        playerStatus = GetComponent<PlayerStatus>();
    }
}
