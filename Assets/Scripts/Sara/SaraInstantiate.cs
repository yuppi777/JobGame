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
    [Header("���X�|�[�����u�̃I���I�t")]
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
