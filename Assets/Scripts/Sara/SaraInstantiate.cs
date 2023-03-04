using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaraInstantiate : MonoBehaviour
{
    [SerializeField]
    [Header("�M")]
    private GameObject _sara;

    [SerializeField]
    [Header("���X�|�[���G���A")]
    private Transform _spwnearia;

    [SerializeField]
    [Header("�����̃C���^�[�o��")]
    private float _interval;

    [SerializeField]
    [Header("������")]
    private int _count;

    [SerializeField]
    [Header("���X�|�[�����u�̃I���I�t")]
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
