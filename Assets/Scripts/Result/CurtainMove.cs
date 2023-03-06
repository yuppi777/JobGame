using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class CurtainMove : MonoBehaviour
{
    [SerializeField]
    [Header("シャッター")]
    private Image _curten;

    [SerializeField]
    [Header("シャッターが降りる速度")]
    private float closeSpeed;

    public float CloseSpeed { get => closeSpeed;  }

    public void CloseCurtem()
    {
        _curten.rectTransform.DOAnchorPosY(0, closeSpeed)
            .SetLink(gameObject)
             .SetEase(Ease.Linear);


    }
    
    
}
