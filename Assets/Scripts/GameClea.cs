using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class GameClea : MonoBehaviour
{
    [SerializeField]
    [Header("皿生成装置")]
    private SaraInstantiate _saraInstantiate;

    [SerializeField]
    [Header("リザルトボタン")]
    private GameObject _resultButton;

    [SerializeField]
    [Header("タイトルボタン")]
    private GameObject _titolbottun;

    private void Start()
    {
        _saraInstantiate.ObserveEveryValueChanged(y => y.IsInstantiateCleaEnd)
                                                 .Where(y => y)
                                                 .Subscribe(_ =>CleaMove());
                                                 
    }
    private void CleaMove()
    {
        _resultButton.gameObject.SetActive(true);
        //_titolbottun.gameObject.SetActive(true);
        AudioManager.Instance.PlayBGM("clea");
    }
}
