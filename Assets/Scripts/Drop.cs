using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class Drop : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        print("’u‚¢‚½");
        var results = new List<RaycastResult>();
        EventSystem.current.RaycastAll(eventData, results);
        foreach (var hit in results)
        {
            if (hit.gameObject.TryGetComponent(out IDrop drop))
            {
                drop.Drop();
                transform.position = hit.gameObject.transform.position;
            }
        }
    }
}
