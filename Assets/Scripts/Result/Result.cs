using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using UniRx;

public class Result : MonoBehaviour
{
    [SerializeField]
    [Header("�������낷�X�N���v�g")]
    private CurtainMove _curtainMove;

    [SerializeField]
    [Header("���ʔ��\�e�L�X�g")]
    private Text _totaltext;
    [SerializeField]
    [Header("�������o���e�L�X�g")]
    private Text rightPointText;

    [SerializeField]
    [Header("�s�����̐����o���e�L�X�g")]
    private Text incorePointText;

    [SerializeField]
    [Header("���v�|�C���g���o���e�L�X�g")]
    private Text totalPointText;

    private int _totalPoint = 0;

    [SerializeField]
    private int _plusPoint;

    [SerializeField]
    private int _minusPoint;


    private PointSheet _pointSheet;
    void Start()
    {
        _pointSheet = GameObject.Find("PointSheet").GetComponent<PointSheet>();

       
        StartCoroutine(ScoreUpdate());
        
    }

    
    IEnumerator ScoreUpdate()
    {
        _curtainMove.CloseCurtem();
        yield return new WaitForSeconds(_curtainMove.CloseSpeed);
        _totaltext.gameObject.SetActive(true);
        yield return new WaitForSeconds(1f);
        rightPointText.gameObject.SetActive(true);
        NumAnimation(_pointSheet._truePoint);
        yield return new WaitForSeconds(0.5f);
        incorePointText.gameObject.SetActive(true);
        NumAnimation(_pointSheet._falsePoint);
        yield return new WaitForSeconds(0.5f);
        totalPointText.gameObject.SetActive(true);
        TotalCalculation();

        Destroy(_pointSheet.gameObject);
       
    }
    private void TotalCalculation()
    {
        _totalPoint = _pointSheet._truePoint * _plusPoint - _pointSheet._falsePoint * _minusPoint;
        NumAnimation(_totalPoint);
    }

    private Tween T_Score =  null;
    private int DisplayScore = 0;

    [SerializeField]
    private float Speed;
    private void NumAnimation(int num)
    {
        DOTween.Kill(T_Score);
        T_Score = DOTween.To(() => DisplayScore, Display, num, Speed);
    }
    private void Display(int valu)
    {
        DisplayScore = valu;

        rightPointText.text = ("����") + ("  ") + _pointSheet._truePoint.ToString() + ("�~") + ("200pt");
        incorePointText.text = ("�s����") + ("  ") + _pointSheet._falsePoint.ToString() + ("�~") + ("100pt");
        totalPointText.text = "���v" + " " + _totalPoint.ToString() + "pt";
    }
}
