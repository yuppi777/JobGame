using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaneMaster : MonoBehaviour
{
    [SerializeField] 
    private List<GameObject> _rane;

    GameObject[] step = new GameObject[10];

    [SerializeField] 
    [Header("���[���̓����X�s�[�h")]
    private float speed;


    
    private float disappear = -10;

    
    private float respawn = 30;
         
    void Start()
    {
        for (int i = 0; i < step.Length; i++)
        {
            step[i] = Instantiate(_rane[i], new Vector3(4 * i, 0, 0), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < step.Length; i++)
        {
            step[i].gameObject.transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);
            if (step[i].gameObject.transform.position.x < disappear)
            {
                step[i].gameObject.transform.position = new Vector3(respawn, 0, 0);
            }
        }
    }


  
}
