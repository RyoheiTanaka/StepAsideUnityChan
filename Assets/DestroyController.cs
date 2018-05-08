using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyController : MonoBehaviour {
	// Unityちゃんのオブジェクト
	private GameObject unitychan;
	// MainCameraのオブジェクト
	private GameObject mainCamera;
	// Unityちゃんとカメラの距離
	private float difference;

	// Use this for initialization
	void Start () {
		// Unityちゃんのオブジェクトを取得
		this.unitychan = GameObject.Find("unitychan");
		// MainCameraのオブジェクトを取得
		this.mainCamera = GameObject.Find("Main Camera");
		// Unityちゃんとカメラの位置(z座標)の差を求める
		this.difference = unitychan.transform.position.z - mainCamera.transform.position.z;
	}
	
	// Update is called once per frame
	void Update () {
		//　ユニティちゃんが通り過ぎて画面外に出たアイテムを破棄
		if(unitychan.transform.position.z - this.transform.position.z > difference) {
			Destroy(this.gameObject);
		}
	}
}
