using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class PlayerController : MonoBehaviour
{
    public TextMeshProUGUI ResultText;
    ///<summary>
    ///自分のRigidbody
    ///</summary>
    private Rigidbody m_rigidbody;

    ///<summary>
	/// 動く方向
	///</summary>
    private Vector3 m_moveVector = new Vector3();

    //付け足した
    ///<summary> 
	///プレイヤーのTransform
	///</summary>
    public Transform m_PlayerTransform;

    public float MoveSpeed = 5.0f;
    //Start is called before the first frame update
    // Use this for initialization
    void Start()
    {
        m_PlayerTransform = this.transform;
        m_rigidbody = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        m_moveVector.z = Input.GetAxis("Vertical");
        m_moveVector.x = Input.GetAxis("Horizontal");
        
    }

    private void FixedUpdate()
    {
        m_rigidbody.AddForce(m_moveVector * MoveSpeed, ForceMode.Acceleration);
    }
}
