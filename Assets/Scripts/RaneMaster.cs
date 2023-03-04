using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UniRx.Triggers;

public class RaneMaster : MonoBehaviour
{
    [SerializeField] 
    [Header("レーン")]
    private List<GameObject> _rane;

    [SerializeField] 
    [Header("レーンの動くスピード")]
    public float _speed;
    
    private float _disappear = -10.0f;

    private GameObject[] _step = new GameObject[10];
    
    private float _respawn = 30.0f;
         
    void Start()
    {
        RaneInstantiate();

        this.UpdateAsObservable().Subscribe(x => Rane());
    }

    private void RaneInstantiate()
    {
        for (int i = 0; i < _step.Length; i++)
        {
            _step[i] = Instantiate(_rane[i], new Vector3(4 * i, -1, 0), Quaternion.identity);
        }
    }

    private void Rane()
    {
        for (int i = 0; i < _step.Length; i++)
        {
            _step[i].gameObject.transform.position -= new Vector3(_speed * Time.deltaTime, 0, 0);
            if (_step[i].gameObject.transform.position.x < _disappear)
            {
                _step[i].gameObject.transform.position = new Vector3(_respawn, -1, 0);
            }
        }
    }
}
