using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System;
using System.Linq;
using UnityEngine.SceneManagement;

public class SushiToppingJudgement : MonoBehaviour 
{
    List<string> _truePattern = new List<string>();

    // List<MySushiTopping> mySushiToppings = new List<MySushiTopping>();

    [SerializeField]
    [Header("ポイントシート")]
    private PointSheet _pointSheet;

    private MySushiTopping mySushiTopping;
    //private MySushiTopping mySushiTopping2;
    private string trueSushiToppingName;
    private bool isSyari = false;

    public string TrueSushiToppingName { get => trueSushiToppingName;  }

    private void Start()
    {
        PatternAdd(SceneManager.GetActiveScene().name);
        trueSushiToppingName = _truePattern.OrderBy(x => Guid.NewGuid()).FirstOrDefault();


        //Judgement();
        Debug.Log(trueSushiToppingName);
        _pointSheet = GameObject.Find("PointSheet").GetComponent<PointSheet>();
        _pointSheet._isFalse = false;

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
            //Judgement();
            //Debug.Log(" 寿司トッピングを開始");
        }
        //Judgement();


    }

    #region リストにAddする関数
    public void PatternAdd(string _stageName)
    {
        if (_stageName == "Stage1")
        {
            _truePattern.Add("Tuna");
            _truePattern.Add("Squid");
        }
        if (_stageName == "Stage2")
        {
          _truePattern.Add("Tuna");
          _truePattern.Add("Squid");
          _truePattern.Add("Kuri");
          _truePattern.Add("Surmon");
        }
        

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
        //if (mySushiTopping == null)
        //{
        //    _pointSheet._isFalse = true;
        //}

        switch (trueSushiToppingName)
        {
            case "Tuna":
                try
                {
                    if (mySushiTopping.myTopping == MySushiTopping.MyTopping.Tuna && isSyari)
                    {

                        _pointSheet._truePoint += 1;

                        Debug.Log("正解");
                    }
                    else
                    {
                        Debug.Log("不正解");
                        _pointSheet._isFalse = true;
                    }
                    Debug.Log("まぐろの皿が作られれば正解です");
                }
                catch (System.Exception)
                {
                    _pointSheet._isFalse = true;
                    Debug.Log("何もネタが乗らなかった");
                }  
                break;
            case "Squid":
                try
                {
                    if (mySushiTopping.myTopping == MySushiTopping.MyTopping.Squid)
                    {
                        _pointSheet._truePoint += 1;
                        Debug.Log("正解");
                    }
                    else
                    {
                        Debug.Log("不正解");
                        _pointSheet._isFalse = true;
                    }
                }
                catch (System.Exception)
                {

                    _pointSheet._isFalse = true;
                    Debug.Log("何もネタが乗らなかった");
                }
                break;
            case "Kuri":
                try
                {
                    if (mySushiTopping.myTopping == MySushiTopping.MyTopping.Kuri)
                    {
                        _pointSheet._truePoint += 1;
                        Debug.Log("正解");
                    }
                    else
                    {
                        Debug.Log("不正解");
                        _pointSheet._isFalse = true;
                    }
                }
                catch (System.Exception)
                {

                    _pointSheet._isFalse = true;
                    Debug.Log("何もネタが乗らなかった");
                }
                break;
            case "Surmon":
                try
                {
                    if (mySushiTopping.myTopping == MySushiTopping.MyTopping.Surmon && isSyari)
                    {

                        _pointSheet._truePoint += 1;

                        Debug.Log("正解");
                    }
                    else
                    {
                        Debug.Log("不正解");
                        _pointSheet._isFalse = true;
                    }
                    Debug.Log("サーモンの皿が作られれば正解です");
                }
                catch (System.Exception)
                {
                    _pointSheet._isFalse = true;
                    Debug.Log("何もネタが乗らなかった");
                }
                break;
        }
        

    }
}
//mySushiToppings.First().myTopping == MySushiTopping.MyTopping.Tuna && mySushiToppings.myTopping == MySushiTopping.MyTopping.Syari

