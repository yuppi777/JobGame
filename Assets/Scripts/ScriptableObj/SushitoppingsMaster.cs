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
    [Header("データ")]
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
        //[Header("名前")]
        //private string _name;

        [SerializeField]
        [Header("寿司ネタのSprite")]
        private Sprite _topping;

        [SerializeField]
        [Header("寿司ネタの部品")]
        private Sprite _toppingparts;


        [SerializeField]
        [Header("寿司ネタの名前")]
        private ToppingName _toppingName;

        
    }
}
