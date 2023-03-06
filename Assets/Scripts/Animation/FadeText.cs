using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class FadeText : MonoBehaviour
{
    [SerializeField]
    [Header("�_�ŊԊu")]
    private float fadeInterval = 1.5f;

    [SerializeField]
    private Ease easeType = Ease.Linear;

    [SerializeField]
    [Header("�_�ł�����e�L�X�g")]
    private Text _fadeText;
    void Start()
    {
        DoFadeText();
    }

    private void DoFadeText()
    {
        _fadeText.DOFade(0.0f, fadeInterval)
                 .SetEase(easeType)
                 .SetLoops(-1, LoopType.Yoyo)
                 .SetLink(gameObject);
                 
    }
}
