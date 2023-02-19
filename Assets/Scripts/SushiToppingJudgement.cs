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

    private MySushiTopping mySushiTopping;
    //private MySushiTopping mySushiTopping2;
    private string trueSushiToppingName;
    private int truePoint;
    private bool isSyari = false;

    private void Start()
    {
        PatternAdd();
        trueSushiToppingName = _truePattern.OrderBy(x => Guid.NewGuid()).FirstOrDefault();
        //Judgement();
        Debug.Log(trueSushiToppingName);

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
                if (mySushiTopping.myTopping == MySushiTopping.MyTopping.Tuna)
                {
                    truePoint += 1;
                    Debug.Log("����");
                }
                else
                {
                    Debug.Log("�s����");
                }
                Debug.Log("�܂���̎M�������ΐ����ł�");
                break;

        }

    }
}
//mySushiToppings.First().myTopping == MySushiTopping.MyTopping.Tuna && mySushiToppings.myTopping == MySushiTopping.MyTopping.Syari

