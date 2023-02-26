using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UniRx.Triggers;

public class MoveSara : MonoBehaviour
{
    //[SerializeField]
    //[Header("���[���𐧌䂵�Ă�X�N���v�g")]
    //private RaneMaster _raneMaster;

    [SerializeField]
    [Header("�M�̓�������")]
    private float _speed;
    void Start()
    {
        this.UpdateAsObservable().Subscribe(x => Move());
    }

   private void Move()
    {
        this.gameObject.transform.position  -= new Vector3(_speed * Time.deltaTime, 0, 0);
    }
   
}
