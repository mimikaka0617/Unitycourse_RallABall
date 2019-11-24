using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollowingCameraController : MonoBehaviour
{
    /// <summary>
    /// 追うべきプレイヤーの場所
    /// </summary>
    private Transform m_playerTransform;

    /// <summary>
    /// 被写体とカメラとの距離
    /// </summary>
    private Vector3 m_cameraOffset;

    // Start is called before the first frame update
    void Start()
    {
        //SoundManager.Instance.PlayBGMSound(SoundManager.BGM_NAME);

        m_playerTransform = GameObject.Find("Player").transform;

        m_cameraOffset = this.transform.position - m_playerTransform.position;

    }

    // Update is called once per frame
    private void LateUpdate()
    {

        if (m_playerTransform != null)
        {
            this.transform.position = m_playerTransform.position + m_cameraOffset;
        }
    }
}
