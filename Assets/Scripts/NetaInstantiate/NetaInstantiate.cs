using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UnityEngine.UI;

public class NetaInstantiate : MonoBehaviour
{
    //[SerializeField]
    //[Header("ネタ")]
    //List<GameObject> _netas;
    [SerializeField]
    [Header("生成用ネタ")]
    private GameObject _neta;

    [SerializeField]
    [Header("今あるネタ")]
    private GameObject _nowneta;


    //private GameObject[] _step = new GameObject[3];

    [SerializeField]
    [Header("リスポーンエリア")]
    private Transform _spwnearia;

    public GameObject Nowneta { get => _nowneta; }

    public void NetaInst()
    {
        //for (int i = 0; i < _step.Length; i++)
        //{
        //    _step[i] = Instantiate(_netas[i], new Vector3(4 * i, 0, 0), Quaternion.identity);
        //}
        GameObject prefab = Instantiate(_neta, _spwnearia.position.normalized, Quaternion.identity);
        prefab.transform.SetParent(_spwnearia.transform, false);

        _nowneta = prefab;
    }

    private void Update()
    {

        if (_nowneta == null)
        {
            NetaInst();
        }
        //重いのはここが原因

    }



}
