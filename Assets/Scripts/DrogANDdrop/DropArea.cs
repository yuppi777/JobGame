using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropArea : MonoBehaviour, IDrop
{
    [SerializeField]
    [Header("�X�R�A")]
    private int _score;

    public void Drop()
    {
       // _score += 50;// �X�R�A�A�b�v
        Debug.Log("�Z�b�g");
        Debug.Log(_score);
    }
   
}
