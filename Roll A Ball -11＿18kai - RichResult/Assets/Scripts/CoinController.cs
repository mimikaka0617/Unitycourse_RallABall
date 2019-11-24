using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    ///<summary> 
	///コインのTransform
	///</summary>
    private Transform m_CoinTransform;

    ///<summary>
    ///回転する方向のVector3
	///</summary>
    private Vector3 m_rollVector = new Vector3();

    // Use this for initialization
    void Start()
    {
        m_CoinTransform = this.transform;
        m_rollVector.y = 50f;
    }

    // Update is called once per frame
    void Update()
    {
        m_CoinTransform.Rotate(m_rollVector * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.name.Equals("Player"))
        {
            GetComponent<EffectManager>().EffectPlay();
            SoundManager.Instance.PlaySESound(SoundManager.COIN_SE_NAME);
            InGameTextManager.Instance.CoinSubtract();
            this.gameObject.SetActive(false);
        }
    }
}
