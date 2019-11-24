using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameStartState :IState
{
    public void Enter()
    {
        SoundManager.Instance.PlayBGMSound(SoundManager.BGM_NAME);
    }

    public void Exit()
    {
        //抜ける時にしたいことがあればここに記述
    }


    public void Update()
    {
        InGameStateManager.Instance.StateMachine.SetState(InGameStateManager.GameStateProcessor.GAMEMAIN);
    }

}
