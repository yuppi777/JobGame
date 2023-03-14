using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System;
using System.Linq;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SushiToppingJudgement : MonoBehaviour 
{
    List<string> _truePattern = new List<string>();

    List<GameObject> _attachObjList = new List<GameObject>();//皿の上に乗ってきたゲームオブジェクト;

    // List<MySushiTopping> mySushiToppings = new List<MySushiTopping>();

    [SerializeField]
    [Header("ポイントシート")]
    private PointSheet _pointSheet;

    [SerializeField]
    [Header("画像が入ってるスクリプタブルオブジェクト")]
    private SushitoppingsMaster _sushiToppingMaster;

    [SerializeField]
    [Header("正解したら出すイメージ")]
    private Image _truesprite;

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

        //if (_pointSheet._isTrue == true)
        //{
        //    AttachObjDestroy();
        //}


        if (other.tag == "Syari")
        {
            isSyari = true;
            _attachObjList.Add(other.gameObject);
        }
        if (other.tag == "SushiTopping")
        {
          mySushiTopping = other.GetComponent<MySushiTopping>();
            _attachObjList.Add(other.gameObject); 
            //mySushiTopping2 = other.GetComponent<MySushiTopping>();
            Judgement();
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
    /// <summary>
    /// 皿に乗っているものを消す関数
    /// </summary>
    private void AttachObjDestroy()
    {
        foreach (GameObject attachobj in _attachObjList)
        {
            Destroy(attachobj);
            //attachobj.gameObject.SetActive(false);
        }
    }
    public void Judgement()
    {
        //Debug.Log("ジャッジメント発動");
        //Debug.Log(isSyari);
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

                        var _sheet = _sushiToppingMaster.Sheet;
                        var nowtruesprite = _sheet.Where(x => x.ToppingNameEnum == SushitoppingsMaster.ToppingName.Tuna).First();
                        _truesprite.gameObject.SetActive(true);
                        _truesprite.sprite = nowtruesprite.Topping;

                        _pointSheet._isTrue = true;
                        AttachObjDestroy();
                        //Debug.Log("正解");
                    }
                    else
                    {
                        //Debug.Log("不正解");
                        _pointSheet._isFalse = true;
                    }
                    //Debug.Log("まぐろの皿が作られれば正解です");
                }
                catch (System.Exception)
                {
                    _pointSheet._isFalse = true;
                    //Debug.Log("何もネタが乗らなかった");
                }  
                break;
            case "Squid":
                try
                {
                    if (mySushiTopping.myTopping == MySushiTopping.MyTopping.Squid)
                    {


                        var _sheet = _sushiToppingMaster.Sheet;
                        var nowtruesprite = _sheet.Where(x => x.ToppingNameEnum == SushitoppingsMaster.ToppingName.Squid).First();
                        _truesprite.gameObject.SetActive(true);
                        _truesprite.sprite = nowtruesprite.Topping;
                        _pointSheet._isTrue = true;
                        AttachObjDestroy();
                        //Debug.Log("正解");
                    }
                    else
                    {
                        //Debug.Log("不正解");
                        _pointSheet._isFalse = true;
                    }
                }
                catch (System.Exception)
                {

                    _pointSheet._isFalse = true;
                    //Debug.Log("何もネタが乗らなかった");
                }
                break;
            case "Kuri":
                try
                {
                    if (mySushiTopping.myTopping == MySushiTopping.MyTopping.Kuri)
                    {

                        var _sheet = _sushiToppingMaster.Sheet;
                        var nowtruesprite = _sheet.Where(x => x.ToppingNameEnum == SushitoppingsMaster.ToppingName.Kuri).First();
                        _truesprite.gameObject.SetActive(true);
                        _truesprite.sprite = nowtruesprite.Topping;
                        

                        _pointSheet._isTrue =true;
                        AttachObjDestroy();
                        //Debug.Log("正解");
                    }
                    else
                    {
                        //Debug.Log("不正解");
                        _pointSheet._isFalse = true;
                    }
                }
                catch (System.Exception)
                {

                    _pointSheet._isFalse = true;
                    //Debug.Log("何もネタが乗らなかった");
                }
                break;
            case "Surmon":
                try
                {
                    if (mySushiTopping.myTopping == MySushiTopping.MyTopping.Surmon && isSyari)
                    {

                        var _sheet = _sushiToppingMaster.Sheet;
                        var nowtruesprite = _sheet.Where(x => x.ToppingNameEnum == SushitoppingsMaster.ToppingName.Surmon).First();
                        _truesprite.gameObject.SetActive(true);
                        _truesprite.sprite = nowtruesprite.Topping;

                        _pointSheet._isTrue = true;
                        AttachObjDestroy();
                        //Debug.Log("正解");
                    }
                    else
                    {
                        //Debug.Log("不正解");
                        _pointSheet._isFalse = true;
                    }
                    //Debug.Log("サーモンの皿が作られれば正解です");
                }
                catch (System.Exception)
                {
                    _pointSheet._isFalse = true;
                    //Debug.Log("何もネタが乗らなかった");
                }
                break;
        }
        

    }
}
//mySushiToppings.First().myTopping == MySushiTopping.MyTopping.Tuna && mySushiToppings.myTopping == MySushiTopping.MyTopping.Syari

