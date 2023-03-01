using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FalsePointUp : MonoBehaviour
{
    [SerializeField]
    [Header("�|�C���g�V�[�g")]
    private PointSheet _pointSheet;

    [SerializeField]
    [Header("�s���𐔕\���e�L�X�g")]
    private Text _falsePointText;

    private SushiToppingJudgement _judgement;
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _judgement = collision.gameObject.GetComponent<SushiToppingJudgement>();
        _judgement.Judgement();
      

        if (_pointSheet._isFalse == true)
        {
            _pointSheet._falsePoint += 1;
        }
        _falsePointText.text = "�s����" + _pointSheet._falsePoint.ToString();

    }
}