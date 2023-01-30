using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropArea : MonoBehaviour, IDrop
{
    [SerializeField]
    [Header("スコア")]
    private int _score;


    public void Drop()
    {
        _score += 50;
        print("セット");
        print(_score);
    }
}
