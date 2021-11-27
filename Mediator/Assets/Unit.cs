using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    [SerializeField] private float hp = 30f;
    [SerializeField] private Mediator mediator;

    private void Start()
    {
        mediator.Subscribe<HpBoostCommand>(OnBoostHP);
    }

    private void OnBoostHP(HpBoostCommand c)
    {
        hp = c.Hp;   
    }

    // Update is called once per frame
    void Update()
    {
        hp -= Time.deltaTime * 2f;
        var cmd = new HpChangedCommand();
        cmd.Hp = hp;
        mediator.Publish(cmd);
    }
}

internal class HpChangedCommand : ICommand
{
    public HpChangedCommand()
    {
    }

    public float Hp { get; internal set; }
}