using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OffScreenDestroy : MonoBehaviour
{
    [SerializeField]
    [Header("生成スクリプト")]
    NetaInstantiate _netaInstantiate;
    // Update is called once per frame
    void Update()
    {
        //if (!GetComponent<Image>().isVisible)
        //{
        //    Destroy(this.gameObject);
        //    _netaInstantiate.NetaInst();
        //}
    }
}
