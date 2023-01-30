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

    public enum JobPost
    {
        Programer,
        Modeler,
        Motion,
        Director
    }

    public enum Rarity
    {
        N = 0,
        R = 1,
        SR = 2,
        SSR = 3
    }
    public enum Nationality
    {
        Japan,
        Jamaica,
        Coria,
    }


    [Serializable]
    public class SushitoppingsMasterRecord
    {
        public string Name => _name;
        public SpriteRenderer SpriteRenderer => _spriteRenderer;
        public Sprite Sprite => _sprite;
        public Sprite FakeSprite => fakeSprite;
        public SushitoppingsMaster.Nationality Nationality => _nationality;
        public string CaraSelif => _caraselif;

        [SerializeField]
        private string _name;

        [SerializeField]
        [Header("�L������SpriteRenderer")]
        private SpriteRenderer _spriteRenderer;

        [SerializeField]
        [Header("�L������Sprite")]
        private Sprite _sprite;

        [SerializeField]
        [Header("ID�ɍڂ���L������Sprite")]
        private Sprite fakeSprite;

        [SerializeField]
        [Header("����")]
        private SushitoppingsMaster.Nationality _nationality;

        [SerializeField]
        [Header("NO�ƌ���ꂽ���̃Z���t")]
        private string _caraselif;
    }
}
