using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallContoroller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt(SaveDataManager.EnemyFlagSaveKey) == 0)
        {
            Destroy(this.gameObject);
        }
    }

    /// <summary>
    /// 接触判定
    /// </summary>
    /// <param name="collision"></param>
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            this.GetComponent<BoxCollider>().isTrigger = true;
        }
        if (collision.gameObject.name.Equals("Enemy"))
        {
            this.GetComponent<BoxCollider>().isTrigger = false;
        }
    }

    /// <summary>
    /// 侵入判定
    /// </summary>
    /// <param name="other"></param>
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Equals("Enemy"))
        {
            this.GetComponent<BoxCollider>().isTrigger = false;
        }
    }
}
