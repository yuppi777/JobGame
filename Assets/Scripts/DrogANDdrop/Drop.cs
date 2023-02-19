using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class Drop : MonoBehaviour, IDropHandler
{
    [SerializeField]
    [Header("�������邽�߂̃X�N���v�g")]
    private NetaInstantiate _netaInstantiate;
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("�u����");
        var results = new List<RaycastResult>();
        EventSystem.current.RaycastAll(eventData, results);
        foreach (var hit in results)
        {
            if (hit.gameObject.TryGetComponent(out IDrop drop))
            {
                drop.Drop();
                transform.position = hit.gameObject.transform.position;
                Debug.Log("Not�폜");
                
            }
            else
            {
                _netaInstantiate.NetaInst();
                Debug.Log("�폜�Ώ�");
               // Destroy(gameObject);

            }
            
            
        }
        
        

        
    }
}
