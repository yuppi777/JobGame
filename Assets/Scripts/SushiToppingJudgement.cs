using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System;
using System.Linq;

public class SushiToppingJudgement : MonoBehaviour 
{
    List<string> _truePattern = new List<string>();

    private void Start()
    {
        PatternAdd();

        string name = _truePattern.OrderBy(x => Guid.NewGuid()).FirstOrDefault();
    }

    #region ƒŠƒXƒg‚ÉAdd‚·‚éŠÖ”
    public void PatternAdd()
    {
        _truePattern.Add("Tuna");
    }
    #endregion 
}
