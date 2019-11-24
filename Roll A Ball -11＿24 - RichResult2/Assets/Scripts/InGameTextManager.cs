using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InGameTextManager : MonoBehaviour
{
    //追加した
    GameObject player;

    PlayerController script;

    ///<summary> 
	///結果を表示するText
	///</summary>
    public TextMeshProUGUI ResultText;

    ///<summary>
    ///InGameTextManagerのインスタンス
    ///</summary>
    public static InGameTextManager Instance = null;

    private void Awake()
    {
        Instance = this;
        ResultText.text = string.Format("{0:00}", InGameStateManager.Instance. CoinCnt);
    }
    //追加
    void Start()
    {
        player = GameObject.Find("Player");
        script = player.GetComponent<PlayerController>();
    }

    void Update()
    {
        Transform PlayerTransform = script.m_PlayerTransform;
        
    }

    public void GameResultShow(bool _GameOver)
    {
        if (_GameOver) {
            ResultText.text = "Game Over";
        }
        else
        {
            ResultText.text = "Game Clear";
            
        }
    }


    ///<summary>
    ///コインをひく関数
    ///</summary>
    public void CoinSubtract()
    {
        InGameStateManager.Instance.CoinCnt -= 1;

            ResultText.text = string.Format("{0:00}", InGameStateManager.Instance.CoinCnt);
       
    }
}
