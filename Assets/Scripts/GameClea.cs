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


    private void Start()
    {
        _saraInstantiate.ObserveEveryValueChanged(y => y.IsInstantiateCleaEnd)
                                                 .Where(y => y)
                                                 .Subscribe(_ =>_resultButton.gameObject.SetActive(true));
                                                 
    }
}
