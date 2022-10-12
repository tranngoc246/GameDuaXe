using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;

    public float timer;
    public float delay =2f;
    public float speed = 25f;
    public float disLimit = 5f;

    float randPos = 0;

    void Awake()
    {
        randPos = Random.Range(-6, 7);
        player = PlayerCtrl.Ins.transform;
    }

    void FixedUpdate()
    {
        Follow();
    }

    void Follow()
    {
        timer += Time.deltaTime;
        if (timer < delay || PlayerCtrl.Ins.damageReceiver.IsDead()) return;

        Vector3 pos = player.position;
        pos.x = randPos;

        Vector3 distance = pos - transform.position;
        if (distance.magnitude >= disLimit)
        {
            Vector3 targetPoint = pos - distance.normalized * disLimit;
            transform.position = Vector3.MoveTowards(gameObject.transform.position, targetPoint, speed * Time.fixedDeltaTime);
        }
    }
}
