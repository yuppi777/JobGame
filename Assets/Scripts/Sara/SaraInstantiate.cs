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

    private int _nowcount;

    
    [Header("���X�|�[�����u�̃I���I�t")]
    public bool isInstantiate;

    private bool isInstantiateCleaEnd = false; //����܂Ő��Y�I���̃u�[��

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
                    
                    Debug.Log("���Y�I��");
                    break;
                }
                yield return new WaitForSeconds(_interval);
                
            }
            if (_nowcount == _count)
            {
                isInstantiateCleaEnd = true;
                Debug.Log("����܂Ő��Y���܂���");
            }

            

        }
    }

  
}
