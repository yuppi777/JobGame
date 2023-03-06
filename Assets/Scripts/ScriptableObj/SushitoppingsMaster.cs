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
        Squid,
        Kuri,
        Surmon,
    }


    [Serializable]
    public class SushitoppingsMasterRecord
    {
        //public string Name => _name;
        public Sprite Topping => _topping;

        public Sprite ToppingParts => _toppingparts;

        

        public SushitoppingsMaster.ToppingName ToppingNameEnum => _toppingName;
        //public string CaraSelif => _caraselif;

        //[SerializeField]
        //[Header("���O")]
        //private string _name;

        [SerializeField]
        [Header("���i�l�^��Sprite")]
        private Sprite _topping;

        [SerializeField]
        [Header("���i�l�^�̕��i")]
        private Sprite _toppingparts;


        [SerializeField]
        [Header("���i�l�^�̖��O")]
        private ToppingName _toppingName;

        
    }
}
