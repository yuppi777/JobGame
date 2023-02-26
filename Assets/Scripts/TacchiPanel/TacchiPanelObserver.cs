using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;
using UniRx;

public class TacchiPanelObserver : MonoBehaviour
{
    [SerializeField]
    [Header("正解画像が入ってるスクリプタブルオブジェクト")]
    private SushitoppingsMaster _sushiToppingMaster;

    private Sprite _nowtruesprite;

    [SerializeField]
    [Header("初期値時のタッチパネルに出す画像")]
    private Sprite _initialSprite;

    [SerializeField]
    [Header("正解画像の出力先")]
    private SpriteRenderer _panel;

    [SerializeField]
    [Header("今の正解のネタがわかるスクリプト")]
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
                    case "初期値":
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
