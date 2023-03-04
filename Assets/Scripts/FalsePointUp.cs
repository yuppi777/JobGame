using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class FalsePointUp : MonoBehaviour
{
    [SerializeField]
    [Header("ポイントシート")]
    private PointSheet _pointSheet;

    [SerializeField]
    [Header("不正解数表示テキスト")]
    private Text _falsePointText;

    [SerializeField]
    [Header("ゲームオーヴァースクリプト")]
    private GameOver _gameOver;

    private SushiToppingJudgement _judgement;
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _judgement = collision.gameObject.GetComponent<SushiToppingJudgement>();
        _judgement.Judgement();

        _gameOver.GameOverMove();
        if (_pointSheet._isFalse == true)
        {
            _pointSheet._falsePoint += 1;
        }
        _falsePointText.text = "不正解数" + _pointSheet._falsePoint.ToString();
       
    }
}
