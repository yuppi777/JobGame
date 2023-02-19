using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class DragObj : MonoBehaviour, IDragHandler, IBeginDragHandler,IEndDragHandler
{

    private Vector2 prevPos;
    [SerializeField]
    [Header("生成スクリプト")]
    private NetaInstantiate _netaInstantiate;
    public void OnBeginDrag(PointerEventData eventData)
    {
        // ドラッグ前の位置を記憶しておく
        prevPos = transform.position;
        //Debug.Log("skfdsdfjs");
    }

    public void OnDrag(PointerEventData eventData)
    {
        // ドラッグ中は位置を更新する
        transform.position = eventData.position;
    }
    public void OnEndDrag(PointerEventData eventData)
    {
        // print($"OnEndDrag : {eventData}");


        _netaInstantiate.NetaInst();
        
    }
}
