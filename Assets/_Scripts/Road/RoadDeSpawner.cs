using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadDeSpawner : MonoBehaviour
{
    protected float distance = 0;

    private void FixedUpdate()
    {
        this.UpdateRoad();
    }

    void UpdateRoad()
    {
        this.distance = Vector3.Distance(PlayerCtrl.Ins.transform.position, transform.position);
        if(this.distance >= 70) {
            Destroy(gameObject);
        }
    }
}
