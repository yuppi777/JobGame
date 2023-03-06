using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointSheet : MonoBehaviour
{
    public int _truePoint;
    public int _falsePoint;
    public bool _isFalse = false;//•s³‰ğ‚Ìƒu[ƒ‹


    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

}
