using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameInitState : IState
{
    public void Enter()
    {
        Debug.Log("InitStart");
    }

    public void Update()
    {
        InGameStateManager.Instance.StateMachine.SetState(InGameStateManager.GameStateProcessor.START);
    }

    public void Exit()
    {
        //抜ける時にしたいことがあればここに記述
    }
}
