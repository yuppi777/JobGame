using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class Drop : MonoBehaviour, IDropHandler
{
    [SerializeField]
    [Header("生成するためのスクリプト")]
    private NetaInstantiate _netaInstantiate;

    private void Start()
    {
        _netaInstantiate = this.gameObject.GetComponentInParent<NetaInstantiate>();
    }
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("置いた");
        var results = new List<RaycastResult>();
        EventSystem.current.RaycastAll(eventData, results);
        foreach (var hit in results)
        {
            if (hit.gameObject.TryGetComponent(out IDrop drop))
            {
                drop.Drop();
                transform.position = hit.gameObject.transform.position;
                transform.SetParent(hit.gameObject.transform);
                Debug.Log("Not削除");
                
                
                
            }
            else
            {
                _netaInstantiate.NetaInst();
                Debug.Log("削除対象");
               // Destroy(gameObject);

            }
            
            
        }
        
        

        
    }
}
