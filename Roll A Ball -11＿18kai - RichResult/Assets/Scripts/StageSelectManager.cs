using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StageSelectManager : MonoBehaviour
{
    public Button NextSceneButton;
    public Button HardLevelButton;

    // Start is called before the first frame update
    void Start()
    {
        NextSceneButton.onClick.AddListener(() => SceneControllManager.Instance.GotoNextScene(SceneControllManager.INGAME_SCENE_NAME));
        NextSceneButton.onClick.AddListener(() => SaveDataManager.Instance.GameLevelSettingData(0));

        HardLevelButton.onClick.AddListener(() => SceneControllManager.Instance.GotoNextScene(SceneControllManager.INGAME_SCENE_NAME));
        HardLevelButton.onClick.AddListener(() => SaveDataManager.Instance.GameLevelSettingData(1));
    }

}
