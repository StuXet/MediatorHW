using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpHandler : MonoBehaviour
{
    [SerializeField] private Mediator mediator;
    // Start is called before the first frame update
    void Start()
    {
        mediator.Subscribe<HpChangedCommand>(OnHpChanged);
    }

    void OnHpChanged(HpChangedCommand c)
    {
        GetComponent<Text>().text = c.Hp.ToString("0");
    }
}
