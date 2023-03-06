using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using System;
using DG.Tweening;

public class GameOver : MonoBehaviour
{
    private bool _isgameOver = false;

    [SerializeField]
    [Header("皿を生成するスクリプト")]
    private SaraInstantiate _saraInstantiate;

    [SerializeField]
    [Header("ゲームオーバーを出すテキスト")]
    private Text _gameOverText;

    [SerializeField]
    [Header("店長のプレハブ")]
    private GameObject _bossObj;

    [SerializeField]
    [Header("アドベンチャー画面")]
    private GameObject _advencherObj ;

    [SerializeField]
    [Header("ゲームオーバーを告げるキャラの名前")]
    private Text _bossName;

    [SerializeField]
    [Header("ポイントシート")]
    private PointSheet _pointSheet;

    [SerializeField]
    [Header("ボスのスポーンエリア")]
    private Transform _bossSpwnArea;

    [SerializeField]
    [Header("リトライボタン")]
    private Button _retryButtun;

    [SerializeField]
    [Header("タイトルボタン")]
    private Button _titleBottun;


    List<string> _gameOverSerifList = new List<string>();
    private string _gameOverSerif;

    private void Start()
    {
        PatternAdd();
         _gameOverSerif = _gameOverSerifList.OrderBy(x => Guid.NewGuid()).FirstOrDefault();
    }

    #region リストにAddする関数
    public void PatternAdd()
    {
        _gameOverSerifList.Add("今日はもう帰っていいよ");
        _gameOverSerifList.Add("お客様からクレーム来たよ");
        _gameOverSerifList.Add("研修期間もう終わってるよ？");
        _gameOverSerifList.Add("会社は学校じゃないんだよ？");
        _gameOverSerifList.Add("クレームが止まらないよ");
        _gameOverSerifList.Add("クビ、カナ？");

    }
    #endregion 

    public void GameOverMove()
    {
        //Debug.Log(_saraInstantiate.Count / 2);
        if (_pointSheet._falsePoint >= _saraInstantiate.Count / 2  && _isgameOver == false)
        {
            
            Debug.Log("ゲームオーバー");
            StartCoroutine(_gameOverMove());
            _saraInstantiate.isInstantiate = false;
            _isgameOver = true;
            AudioManager.Instance.PlayBGM("wafu-gameover");

        }
    }
    IEnumerator _gameOverMove()
    {
        GameObject _boss = Instantiate(_bossObj, _bossSpwnArea.position, Quaternion.identity);

        _boss.transform.DOMoveX(0, 1).SetLink(gameObject);
        yield return new WaitForSeconds(1f);
        _advencherObj.SetActive(true);
        _bossName.text = "店長";
        _gameOverText.text = _gameOverSerif.ToString();
        yield return new WaitForSeconds(5f);
        _advencherObj.SetActive(false);
        _retryButtun.gameObject.SetActive(true);
        _titleBottun.gameObject.SetActive(true);
    }

}
