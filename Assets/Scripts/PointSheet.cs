using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointSheet : MonoBehaviour
{
    public int _truePoint;
    public int _falsePoint;
    public bool _isFalse = false;//不正解時のブール
    public bool _isTrue = false;//正解時のブール


    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

}
