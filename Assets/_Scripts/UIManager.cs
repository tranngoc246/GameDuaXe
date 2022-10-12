using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager Ins;

    public GameObject btnGameOver;

    private void Awake()
    {
        Ins = this;
        btnGameOver = GameObject.Find("ReplayBtn");
        btnGameOver.SetActive(false);
    }
}
