using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class GoToSelectScene : MonoBehaviour
{
    [SerializeField]
    private Camera _camera;

    [SerializeField]
    [Header("ƒJƒƒ‰‚ð‹ß‚Ã‚¯‚é‘¬“x")]
    private float _speed;

    void Start()
    {
       
    }

   public void DOGoToSelectScene()
    {
        //_camera.DOFieldOfView(80f, _speed)
        //       .SetEase(Ease.Linear)
        //       .SetLink(gameObject)
        //       .OnComplete(() => { SceneCange(); });
        SceneCange();
        AudioManager.Instance.PlaySE("iyopon");
    }

    private void SceneCange()
    {
        SceneManagement.Instance.SceneChange("StageSelect");
    }
}
