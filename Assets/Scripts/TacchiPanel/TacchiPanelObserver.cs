using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;
using UniRx;

public class TacchiPanelObserver : MonoBehaviour
{
    [SerializeField]
    [Header("�����摜�������Ă�X�N���v�^�u���I�u�W�F�N�g")]
    private SushitoppingsMaster _sushiToppingMaster;

    private Sprite _nowtruesprite;

    [SerializeField]
    [Header("�����l���̃^�b�`�p�l���ɏo���摜")]
    private Sprite _initialSprite;

    [SerializeField]
    [Header("�����摜�̏o�͐�")]
    private SpriteRenderer _panel;

    [SerializeField]
    [Header("���̐����̃l�^���킩��X�N���v�g")]
    private NowTrueSushiNeta _nowTrueSushiNeta;

    private void Start()
    {
        ChangeTacchiPanelSprite(_nowTrueSushiNeta);
        
    }
    private void ChangeTacchiPanelSprite(NowTrueSushiNeta nowTrueSushiNeta)
    {
        nowTrueSushiNeta.ObserveEveryValueChanged(_nowTrueSushiNeta => _nowTrueSushiNeta.NowTrueSushiName)
            .Subscribe(x => {
                Debug.Log("Change Value : " + x.ToString());
                //_panel.sprite = _nowtruesprite;
                switch (x)
                {
                    case "�����l":
                        _nowtruesprite = _initialSprite;
                        break;
                    case "Tuna":
                        var _sheet = _sushiToppingMaster.Sheet;
                        var nowtruesprite = _sheet.Where(x => x.ToppingNameEnum == SushitoppingsMaster.ToppingName.Tuna).First();
                        _nowtruesprite = nowtruesprite.Topping;
                        _panel.sprite = _nowtruesprite;
                        break;
                    case "Squid":
                        _sheet = _sushiToppingMaster.Sheet;
                        nowtruesprite = _sheet.Where(x => x.ToppingNameEnum == SushitoppingsMaster.ToppingName.Squid).First();
                        _nowtruesprite = nowtruesprite.Topping;
                        _panel.sprite = _nowtruesprite;
                        break;
                }
            })
            .AddTo(gameObject);
    }

}
