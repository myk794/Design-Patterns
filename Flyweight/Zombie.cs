using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    private int _idleState = 0;
    private int _currentHp = 100;
    private int _iq = 32;

    private float _maxSpeed;
    private float _maxHp;

    private void Start()
    {
        _maxHp = ZombieData.MaxHp;
        _maxSpeed = ZombieData.MaxSpeed;
    }
}
