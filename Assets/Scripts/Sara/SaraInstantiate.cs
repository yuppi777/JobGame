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

    private int _nowcount;

    
    [Header("リスポーン装置のオンオフ")]
    public bool isInstantiate;

    private bool isInstantiateCleaEnd = false; //上限まで生産終了のブール

    public int Count { get => _count; }
    public bool IsInstantiateCleaEnd { get => isInstantiateCleaEnd; }

    private void Start()
    {
        StartCoroutine(SaraInst());
    }
    IEnumerator SaraInst()
    {
        if (isInstantiate)
        {
            for ( _nowcount = 0; _nowcount < _count; _nowcount++)
            {
                
                GameObject prefab = Instantiate(_sara, _spwnearia.position.normalized, Quaternion.identity);
                prefab.transform.SetParent(_spwnearia.transform, false);
                if (isInstantiate == false)
                {
                    
                    Debug.Log("生産終了");
                    break;
                }
                yield return new WaitForSeconds(_interval);
                
            }
            if (_nowcount == _count)
            {
                isInstantiateCleaEnd = true;
                Debug.Log("上限まで生産しまいた");
            }

            

        }
    }

  
}
