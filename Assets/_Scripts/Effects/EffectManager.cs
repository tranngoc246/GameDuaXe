using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectManager : MonoBehaviour
{
    public static EffectManager Ins;
    List<GameObject> effects;

    private void Awake()
    {
        Ins = this;
        LoadEffect();
    }

    void LoadEffect()
    {
        effects = new List<GameObject>();
        foreach(Transform child in transform)
        {
            effects.Add(child.gameObject);
            child.gameObject.SetActive(false);
        }
    }

    public void SpawnVFX(string effectName, Vector3 pos, Quaternion rot)
    {
        GameObject effect = Get(effectName);
        GameObject newEffect = Instantiate(effect, pos, rot);
        newEffect.SetActive(true);
    }

    GameObject Get(string effecName)
    {
        foreach(GameObject child in this.effects)
        {
            if (child.name == effecName) return child;
        }
        return null;
    }
}
