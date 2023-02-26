using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UniRx.Triggers;

public class MoveSara : MonoBehaviour
{
    //[SerializeField]
    //[Header("レーンを制御してるスクリプト")]
    //private RaneMaster _raneMaster;

    [SerializeField]
    [Header("皿の動く速さ")]
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
