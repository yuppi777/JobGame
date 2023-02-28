using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeMaster : MonoBehaviour
{
    [SerializeField]
    [Header("�������Ԃ�\������e�L�X�g")]
    Text timer;

    [SerializeField] 
    [Header("�^�C�����~�b�g")]
    private float timeLimit;
   
    private float moveTime;

    void Start()
    {
        moveTime = timeLimit;
        timer.text = timeLimit.ToString();
        
    }
    public bool TimeController(float deltaTime)
    {
        moveTime = moveTime - deltaTime;
        timer.text = Mathf.CeilToInt(moveTime).ToString();
        if (moveTime <= 0.0f)
        {
            timer.text = ("0");
            return false;
        }
        return true;
    }
    public void SetReStartTime()
    {
        moveTime = timeLimit;
    }
}
