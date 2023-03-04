using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaraInstantiate : MonoBehaviour
{
    [SerializeField]
    [Header("皿")]
    private GameObject _sara;

    [SerializeField]
    [Header("リスポーンエリア")]
    private Transform _spwnearia;

    [SerializeField]
    [Header("生成のインターバル")]
    private float _interval;

    [SerializeField]
    [Header("生成数")]
    private int _count;

    [SerializeField]
    [Header("リスポーン装置のオンオフ")]
    private bool isInstantiate;

    public int Count { get => _count; }

    private void Start()
    {
        StartCoroutine(SaraInst());
    }
    IEnumerator SaraInst()
    {
        if (isInstantiate)
        {
            for (int count = 0; count < _count; count++)
            {
                GameObject prefab = Instantiate(_sara, _spwnearia.position.normalized, Quaternion.identity);
                prefab.transform.SetParent(_spwnearia.transform, false);
                yield return new WaitForSeconds(_interval);
            }

        }
    }

  
}
