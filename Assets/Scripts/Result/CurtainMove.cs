using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class CurtainMove : MonoBehaviour
{
    [SerializeField]
    [Header("�V���b�^�[")]
    private Image _curten;

    [SerializeField]
    [Header("�V���b�^�[���~��鑬�x")]
    private float closeSpeed;

    public float CloseSpeed { get => closeSpeed;  }

    public void CloseCurtem()
    {
        _curten.rectTransform.DOAnchorPosY(0, closeSpeed)
            .SetLink(gameObject)
             .SetEase(Ease.Linear);


    }
    
    
}
