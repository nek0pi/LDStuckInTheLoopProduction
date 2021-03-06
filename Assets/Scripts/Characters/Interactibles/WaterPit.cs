﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterPit : MonoBehaviour
{
    private void Start()
    {
        GameManager.instance.onReset += OnReset;
        GameManager.instance.isWaterPuddlePlaced = true;
        ElectrifyIt();
    }

    public void ElectrifyIt()
    {
        if(ElectricPuddleManager.instance.PlaceElectricPuddle() == true)
        {
            //gameObject.SetActive(false);
        }
    }

    public void OnReset(int n) { GameManager.instance.onReset -= OnReset; gameObject.SetActive(false); }
}
