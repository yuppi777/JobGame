using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropArea : MonoBehaviour, IDrop
{
    [SerializeField]
    [Header("�X�R�A")]
    private int _score;


    public void Drop()
    {
        _score += 50;
        print("�Z�b�g");
        print(_score);
    }
}
