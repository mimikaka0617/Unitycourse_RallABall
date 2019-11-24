using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ResultSceneManager : MonoBehaviour
{   /// <summary>
    /// シーン遷移を設定するボタン
    /// </summary>
    public Button NextSceneButton;

    /// <summary>
    /// ゲーム結果を表示するテキスト
    /// </summary>
    // Start is called before the first frame update
    public TextMeshProUGUI ResultText;

    ///<summary>
    ///ゲームスコアを表示するテキスト
    ///</summary>
    public TextMeshProUGUI ScoreText;

    /// <summary>
    /// スコアを表示する時の表示物
    /// </summary>
    private string YourScore = "YourScore";

    private Material m_resultMaterial;

    private Material m_scoreMaterial;

    private Color resultfontColor;

    private Color scorefontColor;

    

    //Start is called before the first frame update
    void Start()
    {
        NextSceneButton.onClick.AddListener(() => SceneControllManager.Instance.GotoNextScene(SceneControllManager.START_SCENE_NAME));

        //表示物の初期化
        ResultText.text = string.Empty;
        ScoreText.text = string.Empty;

        ///1だったらゲームオーバーなので
        if(PlayerPrefs.GetInt(SaveDataManager.ResultSaveKey) == 1)
        {
            ResultText.text = "GameOver";
        }
        else
        {
            ResultText.text = "GameClear";
            ScoreText.text = string.Format("{0}:{1:00}", YourScore, PlayerPrefs.GetFloat(SaveDataManager.ScoreSaveKey));
        }

        m_scoreMaterial = ScoreText.fontMaterial;
        scorefontColor = m_scoreMaterial.GetColor("_FaceColor");


    }

    private void Update()
    {
        m_scoreMaterial.SetColor("_FaceColor", new Color(scorefontColor.r, scorefontColor.g, scorefontColor.b, Mathf.Sin(Time.time) / 0.5f));
    }



}
