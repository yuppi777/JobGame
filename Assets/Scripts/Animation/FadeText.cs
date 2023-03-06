using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class FadeText : MonoBehaviour
{
    [SerializeField]
    [Header("点滅間隔")]
    private float fadeInterval = 1.5f;

    [SerializeField]
    private Ease easeType = Ease.Linear;

    [SerializeField]
    [Header("点滅させるテキスト")]
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
