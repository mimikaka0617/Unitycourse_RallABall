using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    float MoveActionCount = 1.0f;

    ///<summary>
    /// 動く方向
    ///</summary>
    private Vector3 m_moveVector = new Vector3();

    private Rigidbody m_rigidbody;

    private void Awake()
    {
        if (PlayerPrefs.GetInt(SaveDataManager.EnemyFlagSaveKey) == 0)
        {
            Destroy(this.gameObject);
        }
    }

    private void Start()
    {
        m_rigidbody = this.GetComponent<Rigidbody>();
    }

    private void Update()
    {
        MoveActionCount -= Time.deltaTime;
        if (MoveActionCount < 0)
        {
            m_moveVector = new Vector3();
            m_moveVector.x = Random.Range(-1f, 1f);
            m_moveVector.z = Random.Range(-1f, 1f);
            MoveActionCount = 1.0f;
        }
    }
    private void FixedUpdate()
    {
        m_rigidbody.AddForce(m_moveVector, ForceMode.Acceleration);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
           InGameStateManager.Instance.EnemyCollision = true;
        }
    }
}
