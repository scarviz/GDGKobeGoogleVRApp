using UnityEngine;
using System.Collections;
using System;

public class Warp : MonoBehaviour, IGvrGazeResponder
{
	[SerializeField]
	private GameObject GvrMain;
	[SerializeField]
	private GameObject WarpZone;

	/// <summary>
	/// 視線が当たった時の処理
	/// </summary>
	public void OnGazeEnter()
	{
		Debug.Log("OnGazeEnter");
	}

	/// <summary>
	/// 視線が外れた時の処理
	/// </summary>
	public void OnGazeExit()
	{
		Debug.Log("OnGazeExit");
	}

	/// <summary>
	/// クリック処理
	/// </summary>
	public void OnGazeTrigger()
	{
		Debug.Log("OnGazeTrigger");

		// ワープゾーンの位置
		var warpPos = WarpZone.transform.position;
		// 高さの調整
		warpPos.y += 3;
		// ワープゾーンの位置に移動する
		GvrMain.transform.position = warpPos;
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
