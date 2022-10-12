using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadSpawner : MonoBehaviour
{
    protected GameObject roadPrefab;
    protected GameObject roadSpawnPos;
    protected GameObject roadCurrent;

    float distance = 0;
    int roadLayerOrder;

    private void Awake()
    {
        roadPrefab = GameObject.Find("RoadPrefab");
        roadPrefab.SetActive(false);

        roadSpawnPos = GameObject.Find("RoadSpawnPos");

        roadLayerOrder = (int) this.roadPrefab.transform.position.z;

        Spawn(roadPrefab.transform.position);
    }

    private void FixedUpdate()
    {
        this.UpdateRoad();
    }

    public virtual void UpdateRoad()
    {
        this.distance = Vector2.Distance(PlayerCtrl.Ins.transform.position, this.roadCurrent.transform.position);
        if (distance >= 40) Spawn();
    }

    void Spawn()
    {
        Vector3 pos = this.roadSpawnPos.transform.position;
        pos.x = 0;
        pos.z = this.roadLayerOrder;
        Spawn(pos);
    }

    void Spawn(Vector3 pos)
    {
        roadCurrent = Instantiate(this.roadPrefab, pos, this.roadSpawnPos.transform.localRotation);
        roadCurrent.transform.parent = transform;
        roadCurrent.SetActive(true);
    }
}
