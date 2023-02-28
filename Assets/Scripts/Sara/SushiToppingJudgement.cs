using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System;
using System.Linq;

public class SushiToppingJudgement : MonoBehaviour 
{
    List<string> _truePattern = new List<string>();

    // List<MySushiTopping> mySushiToppings = new List<MySushiTopping>();

    [SerializeField]
    [Header("�|�C���g�V�[�g")]
    private PointSheet _pointSheet;

    private MySushiTopping mySushiTopping;
    //private MySushiTopping mySushiTopping2;
    private string trueSushiToppingName;
    private bool isSyari = false;

    public string TrueSushiToppingName { get => trueSushiToppingName;  }

    private void Start()
    {
        PatternAdd();
        trueSushiToppingName = _truePattern.OrderBy(x => Guid.NewGuid()).FirstOrDefault();
        //Judgement();
        Debug.Log(trueSushiToppingName);
        _pointSheet = GameObject.Find("PointSheet").GetComponent<PointSheet>();

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
       
       
        if (other.tag == "Syari")
        {
            isSyari = true;
        }
        if (other.tag == "SushiTopping")
        {
          mySushiTopping = other.GetComponent<MySushiTopping>();
            //mySushiTopping2 = other.GetComponent<MySushiTopping>();
            Judgement();
            //Debug.Log(" ���i�g�b�s���O���J�n");
        }

      
       
    }

    #region ���X�g��Add����֐�
    public void PatternAdd()
    {
        _truePattern.Add("Tuna");
        _truePattern.Add("Squid");

    }
    #endregion 


    public void Judgement()
    {
        Debug.Log("�W���b�W�����g����");
        Debug.Log(isSyari);
        //mySushiToppings.Where

        //if (trueSushiToppingName == mySushiTopping.myTopping)
        //{
        //    truePoint += 1;
        //    Debug.Log("����");
           
        //}

        switch (trueSushiToppingName)
        {
            case "Tuna":
                if (mySushiTopping.myTopping == MySushiTopping.MyTopping.Tuna && isSyari)
                {
                   
                    _pointSheet._truePoint += 1;

                    Debug.Log("����");
                }
                else
                {
                    Debug.Log("�s����");
                }
                Debug.Log("�܂���̎M�������ΐ����ł�");
                break;
            case "Squid":
                if (mySushiTopping.myTopping == MySushiTopping.MyTopping.Squid )
                {
                    _pointSheet._truePoint += 1;
                    Debug.Log("����");
                }
                else
                {
                    Debug.Log("�s����");
                }
                Debug.Log("�C�J�̎M�������ΐ����ł�");
                break;

        }

    }
}
//mySushiToppings.First().myTopping == MySushiTopping.MyTopping.Tuna && mySushiToppings.myTopping == MySushiTopping.MyTopping.Syari

