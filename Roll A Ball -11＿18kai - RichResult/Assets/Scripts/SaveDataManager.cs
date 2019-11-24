using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveDataManager : SingletonBase<SaveDataManager>
{
    public const string ResultSaveKey = "Result";
    public const string ScoreSaveKey = "Score";

    public const string EnemyFlagSaveKey = "Enemy";

    protected override void Awake()
    {
        base.Awake();
    }

    ///<summary>
    ///ゲーム結果のセーブをする
    ///</summary>
    ///<param name="_ResultTime">クリアしたときの残タイム</param>
    ///<param name="_gameOver">0か1を保存する 0 = ゲームクリア,1 = ゲームオーバー</param>
    public void SaveGameData(float _ResultTime, int _gameOver)
    {
        PlayerPrefs.SetInt(ResultSaveKey, _gameOver);
        PlayerPrefs.SetFloat(ScoreSaveKey, _ResultTime);
        PlayerPrefs.Save();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="_enemyFlag">敵の発生フラグture＝1、false＝0</param>
    public void GameLevelSettingData(int _enemyFlag)
    {
        PlayerPrefs.SetInt(EnemyFlagSaveKey, _enemyFlag);
        PlayerPrefs.Save();
    }

}
