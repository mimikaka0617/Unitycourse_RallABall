using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenTransition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //SceneControllManager.Instance.GotoNextScene("StageSelect");
        //SceneControllManager.Instance.GotoNextScene("Result");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //追加した
    //ボタンを押した時の処理
    public void PushStageSelectButton()
    {
        SceneControllManager.Instance.GotoNextScene("StageSelect");
    }

    public void PushResultButton()
    {
        SceneControllManager.Instance.GotoNextScene("Result");
    }
}
