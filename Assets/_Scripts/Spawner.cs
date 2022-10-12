using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [Header("Spawner")]
    public GameObject objPrefab;
    public GameObject objSpawnPos;
    public float timer = 0f;
    public float deplay = 2f;
    public List<GameObject> objs;
    public int maxObj = 1;
    public string prefabName = "";
    public string spawnPosName = "";

    private void Awake()
    {
        objPrefab = GameObject.Find(this.prefabName);
        objPrefab.SetActive(false);

        objSpawnPos = GameObject.Find(this.spawnPosName);

        objs = new List<GameObject>();
    }

    private void Update()
    {
        this.Spawn();
        this.CheckEnemyDead();
    }

    public void CheckEnemyDead()
    {
        for (int i = 0; i < this.objs.Count; i++)
        {
            if (this.objs[i] == null)
            {
                this.objs.RemoveAt(i);
            }
        }
    }

    public void Spawn()
    {
        if (PlayerCtrl.Ins.damageReceiver.IsDead()) return;

        if (objs.Count >= maxObj) return;

        timer += Time.deltaTime;
        if (timer < deplay) return;
        timer = 0;

        GameObject obj = Instantiate(this.objPrefab);
        obj.transform.position = objSpawnPos.transform.position;
        obj.transform.parent = transform;
        obj.SetActive(true);

        objs.Add(obj);
    }
}
