using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinInstantiateManager : MonoBehaviour
{
    /// <summary>
    /// CoinRootを設定
    /// </summary>
    public GameObject CoinRoot = null;

    /// <summary>
    /// CoinRootの位置(Position)を設定する配列を作成
    /// </summary>
    public Vector3[] CoinPos = new Vector3[8];

	//Start is called before the first frame update
	void Start ()
    {
		for(int i = 0; i < CoinPos.Length; i++)
        {
            //GameObjectの生成
            Instantiate(CoinRoot,CoinPos[i], Quaternion.identity, this.transform);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
