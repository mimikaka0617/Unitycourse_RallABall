using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameResultState : IState
{
    private InGameStateManager stateManager = InGameStateManager.Instance;

    private bool m_gameEnd = false;

    public void Enter()
    {

        Debug.Log("result");
        InGameTextManager.Instance.GameResultShow(stateManager.GameOver);

        if(stateManager.GameOver)
        {
            SoundManager.Instance.PlayBGMSound(SoundManager.GAMEOVER_BGM_NAME);
            SceneControllManager.Instance.GotoNextScene(SceneControllManager.RESULT_SCENE_NAME);
        }
        else
        {
            SoundManager.Instance.PlayBGMSound(SoundManager.CLEAR_BGM_NAME);
        }
        ///Scenemanagrr
        ///データを保存する
        SaveDataManager.Instance.SaveGameData(stateManager.GameTime, System.Convert.ToInt32(stateManager.GameOver));

        //リザルトでScene移動する
        SceneControllManager.Instance.GotoNextScene(SceneControllManager.RESULT_SCENE_NAME);
    }

    public void Update()
    {
        if(!m_gameEnd)
        {
            m_gameEnd = true;
        }
    }
    public void Exit()
    {
        //抜ける時にしたいことがあればここに記述
    }
    
}
