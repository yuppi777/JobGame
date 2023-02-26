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
    [Header("リスポーン装置のオンオフ")]
    private bool isInstantiate;

    private void Start()
    {
        StartCoroutine(SaraInst());
    }
    IEnumerator SaraInst()
    {
        while (isInstantiate)
        { GameObject prefab = Instantiate(_sara, _spwnearia.position.normalized, Quaternion.identity);
            prefab.transform.SetParent(_spwnearia.transform, false);
            yield return new WaitForSeconds(_interval);
        }
    }

  
}
