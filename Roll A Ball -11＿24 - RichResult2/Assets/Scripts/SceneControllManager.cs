using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControllManager : SingletonBase<SceneControllManager>
{
    public const string START_SCENE_NAME = "Start";
    public const string SELECT_SCENE_NAME = "StageSelect";
    public const string INGAME_SCENE_NAME = "GameMain";
    public const string RESULT_SCENE_NAME = "Result";

    private string CurrentSceneName = string.Empty;

    protected override void Awake()
    {
        base.Awake();
        CurrentSceneName = SceneManager.GetActiveScene().name;
    }

    /// <summary>
    /// シーンの変遷
    /// </summary>
    /// <param name="_nextScene"></param>
    public void GotoNextScene(string _nextScene,bool _additive = false,string _additiveScene = null)
    {
        CurrentSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(_nextScene);

        // もしadditiveがtrueなら二つ目のシーンを呼ぶ
        if(_additive)
        {
            //additiveがtrueでも_additiveSceneのstringがなければ帰る
            if(string.IsNullOrEmpty(_additiveScene))
            {
                return;
            }
            //additiveSceneをサブシーンとして呼ぶ出す
            SceneManager.LoadScene(_additiveScene, LoadSceneMode.Additive);
        }
    }
    /// <summary>
    /// シーンを戻る
    /// </summary>
    public void ReturnBackScene()
    {
        SceneManager.LoadScene(CurrentSceneName);
    }
    
}
