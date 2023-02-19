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
    [Header("ネタ")]
    private GameObject _neta;


    //private GameObject[] _step = new GameObject[3];

    [SerializeField]
    [Header("リスポーンエリア")]
    private Transform _spwnearia;

    void Start()
    {
        //_spwnearia.position = this.gameObject.transform.position;
    }

    public void NetaInst()
    {
        //for (int i = 0; i < _step.Length; i++)
        //{
        //    _step[i] = Instantiate(_netas[i], new Vector3(4 * i, 0, 0), Quaternion.identity);
        //}
        GameObject prefab = Instantiate(_neta, _spwnearia.position.normalized, Quaternion.identity);
        prefab.transform.SetParent(_spwnearia.transform, false);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
