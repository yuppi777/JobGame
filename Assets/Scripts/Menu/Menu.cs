using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class Menu : MonoBehaviour
{
    [SerializeField]
    [Header("���j���[���")]
    private Image _menu;

    private void Awake()
    {
        _menu.transform.DOScale(new Vector3(0f, 0f, 0), 0f);
        _menu.gameObject.SetActive(true);
        
    }

    /// <summary>
    /// ���j���[���J������
    /// </summary>
    public void OnClick()
    {
        _menu.transform.DOScale(new Vector3(1f, 1f, 0),1f);
    }

    public void OnClose()
    {
        _menu.transform.DOScale(new Vector3(0f, 0f, 0), 1f);
    }
}
