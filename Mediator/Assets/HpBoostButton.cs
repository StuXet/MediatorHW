using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpBoostButton : MonoBehaviour
{
    [SerializeField] private Mediator mediator;
    public void OnClick()
    {
        HpBoostCommand cmd = new HpBoostCommand();
        cmd.Hp = 30f;
        mediator.Publish<HpBoostCommand>(cmd);
    }
}

internal class HpBoostCommand : ICommand
{

    public float Hp { get;  set; }

    
}