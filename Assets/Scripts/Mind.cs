﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
using UnityStandardAssets.Cameras;

public class Mind : MonoBehaviour
{
    public FreeLookCam Cam;
    public static Mind Instance;
    public GameObject Mario;
    public GameObject[] Players;
    [SerializeField] private GameObject CurrentPlayer;
    void Start()
    {
        for (int i = 1; i < Players.Length; i++)
        {
            Players[i].GetComponent<newthirdperson>().enabled = false;
        }

        CurrentPlayer = Players[0];
    }

    private void Awake()
    {
        Instance = this;
    }

    public void ChangePlayer(GameObject player)
    {
        CurrentPlayer.GetComponent<newthirdperson>().enabled = false;
        CurrentPlayer = player;
        Cam.SetTarget(CurrentPlayer.transform);
        CurrentPlayer.GetComponent<newthirdperson>().enabled = true;
        Debug.Log(CurrentPlayer);
        Mario.SetActive(false);
    }

}