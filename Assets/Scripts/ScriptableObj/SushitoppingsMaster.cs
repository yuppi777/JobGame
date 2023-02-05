using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "ScriptableObject/CreateAsset")]
public class SushitoppingsMaster : ScriptableObject
{
    public List<SushitoppingsMasterRecord> Sheet => _sheet;

    [SerializeField]
    [Header("�f�[�^")]
    List<SushitoppingsMasterRecord> _sheet;

    

    public enum Rarity
    {
        N = 0,
        R = 1,
        SR = 2,
        SSR = 3
    }
    public enum ToppingName
    {
        Tuna,
        Shari,
        Coria,
    }


    [Serializable]
    public class SushitoppingsMasterRecord
    {
        //public string Name => _name;
        public Sprite Image => _topping;
        public Sprite Sprite => _sprite;
        public Sprite FakeSprite => _fakeSprite;
        public SushitoppingsMaster.ToppingName Nationality => _toppingName;
        //public string CaraSelif => _caraselif;

        //[SerializeField]
        //[Header("���O")]
        //private string _name;

        [SerializeField]
        [Header("���i�l�^��SpriteRenderer")]
        private Sprite _topping;

        [SerializeField]
        [Header("�L������Sprite")]
        private Sprite _sprite;

        [SerializeField]
        [Header("ID�ɍڂ���L������Sprite")]
        private Sprite _fakeSprite;

        [SerializeField]
        [Header("���i�l�^")]
        private ToppingName _toppingName;

        //[SerializeField]
        //[Header("NO�ƌ���ꂽ���̃Z���t")]
        //private string _caraselif;
    }
}
