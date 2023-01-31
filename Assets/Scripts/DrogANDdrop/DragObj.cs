using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class DragObj : MonoBehaviour, IDragHandler, IBeginDragHandler
{

    private Vector2 prevPos;
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
    }
}
