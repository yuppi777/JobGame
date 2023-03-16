using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class DragObj : MonoBehaviour, IDragHandler, IBeginDragHandler,IEndDragHandler
{

    private Vector2 prevPos;
    [SerializeField]
    [Header("�����X�N���v�g")]
    private NetaInstantiate _netaInstantiate;

    private void Start()
    {
        _netaInstantiate = this.gameObject.GetComponentInParent<NetaInstantiate>();
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        // �h���b�O�O�̈ʒu���L�����Ă���
        prevPos = transform.position;
        //Debug.Log("skfdsdfjs");
    }

    public void OnDrag(PointerEventData eventData)
    {
        // �h���b�O���͈ʒu���X�V����
        transform.position = eventData.position;

        //if (_netaInstantiate.Nowneta == null)
        //{
        // _netaInstantiate.NetaInst();
        //}
        
    }
    public void OnEndDrag(PointerEventData eventData)
    {
        // print($"OnEndDrag : {eventData}");


        //_netaInstantiate.NetaInst();
        
    }
}
