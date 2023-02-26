using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NowTrueSushiNeta : MonoBehaviour
{
    private string _nowTrueSushiName;

    private SushiToppingJudgement _sushiToppingJudgement;

    public string NowTrueSushiName { get => _nowTrueSushiName;  }

    private void Start()
    {
        _nowTrueSushiName = "‰Šú’l";
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _sushiToppingJudgement = collision.gameObject.GetComponent<SushiToppingJudgement>();
        _nowTrueSushiName = _sushiToppingJudgement.TrueSushiToppingName;
        Debug.Log("¡‚ÌM‚Ì³‰ğ‚Í" + _nowTrueSushiName);
    }
}
