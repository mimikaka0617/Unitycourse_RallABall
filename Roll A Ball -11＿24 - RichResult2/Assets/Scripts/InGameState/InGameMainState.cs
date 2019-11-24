using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameMainState : IState
{
    private InGameStateManager stateManager = InGameStateManager.Instance;

    private bool m_stateEnd = false;

    public void Enter()
    {
        Debug.Log("GameMainStart");
    }

    // Update is called once per frame
    public void Update()
    {
        stateManager.GameTime -= Time.deltaTime;
        //InGameTextManager.Instance.TimeCountTextShow();
        if (stateManager.GameTime < 0)
        {
            stateManager.GameOver = true;
            m_stateEnd = true;
        }
        if (stateManager.Player.transform.position.y < -2) //プレイヤーがStageより下に行ったらGameOver
        {
            stateManager.GameOver = true;
            m_stateEnd = true;
        }
        if (stateManager.CoinCnt == 0)//コインが0になったらクリア
        {
            stateManager.GameOver = false;
            m_stateEnd = true;
        }
        if (stateManager.EnemyCollision == true)//敵にあたった場合
        {
            stateManager.GameOver = true;
            m_stateEnd = true;
        }

        if (m_stateEnd == true)
        {
            InGameStateManager.Instance.StateMachine.SetState(InGameStateManager.GameStateProcessor.RESULT);
        }
    }

    public void Exit()
    {
        //抜ける時にしたいことがあればここに記述
    }


    
}

