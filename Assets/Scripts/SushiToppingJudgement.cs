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
            //Debug.Log(" 寿司トッピングを開始");
        }

      
       
    }

    #region リストにAddする関数
    public void PatternAdd()
    {
        _truePattern.Add("Tuna");

    }
    #endregion 


    public void Judgement()
    {
        Debug.Log("ジャッジメント発動");
        Debug.Log(isSyari);
        //mySushiToppings.Where

        //if (trueSushiToppingName == mySushiTopping.myTopping)
        //{
        //    truePoint += 1;
        //    Debug.Log("正解");
           
        //}

        switch (trueSushiToppingName)
        {
            case "Tuna":
                if (mySushiTopping.myTopping == MySushiTopping.MyTopping.Tuna)
                {
                    truePoint += 1;
                    Debug.Log("正解");
                }
                else
                {
                    Debug.Log("不正解");
                }
                Debug.Log("まぐろの皿が作られれば正解です");
                break;

        }

    }
}
//mySushiToppings.First().myTopping == MySushiTopping.MyTopping.Tuna && mySushiToppings.myTopping == MySushiTopping.MyTopping.Syari

