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
    [Header("�M�𐶐�����X�N���v�g")]
    private SaraInstantiate _saraInstantiate;

    [SerializeField]
    [Header("�Q�[���I�[�o�[���o���e�L�X�g")]
    private Text _gameOverText;

    [SerializeField]
    [Header("�X���̃v���n�u")]
    private GameObject _bossObj;

    [SerializeField]
    [Header("�A�h�x���`���[���")]
    private GameObject _advencherObj ;

    [SerializeField]
    [Header("�Q�[���I�[�o�[��������L�����̖��O")]
    private Text _bossName;

    [SerializeField]
    [Header("�|�C���g�V�[�g")]
    private PointSheet _pointSheet;

    [SerializeField]
    [Header("�{�X�̃X�|�[���G���A")]
    private Transform _bossSpwnArea;

    [SerializeField]
    [Header("���g���C�{�^��")]
    private Button _retryButtun;

    [SerializeField]
    [Header("�^�C�g���{�^��")]
    private Button _titleBottun;


    List<string> _gameOverSerifList = new List<string>();
    private string _gameOverSerif;

    private void Start()
    {
        PatternAdd();
         _gameOverSerif = _gameOverSerifList.OrderBy(x => Guid.NewGuid()).FirstOrDefault();
    }

    #region ���X�g��Add����֐�
    public void PatternAdd()
    {
        _gameOverSerifList.Add("�����͂����A���Ă�����");
        _gameOverSerifList.Add("���q�l����N���[��������");
        _gameOverSerifList.Add("���C���Ԃ����I����Ă��H");
        _gameOverSerifList.Add("��Ђ͊w�Z����Ȃ��񂾂�H");
        _gameOverSerifList.Add("�N���[�����~�܂�Ȃ���");
        _gameOverSerifList.Add("�N�r�A�J�i�H");

    }
    #endregion 

    public void GameOverMove()
    {
        //Debug.Log(_saraInstantiate.Count / 2);
        if (_pointSheet._falsePoint >= _saraInstantiate.Count / 2  && _isgameOver == false)
        {
            
            Debug.Log("�Q�[���I�[�o�[");
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
        _bossName.text = "�X��";
        _gameOverText.text = _gameOverSerif.ToString();
        yield return new WaitForSeconds(5f);
        _advencherObj.SetActive(false);
        _retryButtun.gameObject.SetActive(true);
        _titleBottun.gameObject.SetActive(true);
    }

}
