using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropArea : MonoBehaviour, IDrop
{
    [SerializeField]
    [Header("スコア")]
    private int _score;

    public void Drop()
    {
       // _score += 50;// スコアアップ
        Debug.Log("セット");
        Debug.Log(_score);
    }
   
}
