using UnityEngine;
using System.Collections;
using System;

public class Warp : MonoBehaviour, IGvrGazeResponder
{
	[SerializeField]
	private GameObject GvrMain;
	[SerializeField]
	private GameObject WarpZone;
	[SerializeField]
	private GameObject Particle;

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

		// パーティクルを無効にする
		Particle.SetActive(false);
	}

	// Use this for initialization
	void Start () {
		Particle.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		// パーティクルが無効になっている場合
		if (!Particle.activeSelf)
		{
			// x,z座標が一致するかどうか
			var samePos = GvrMain.transform.position.x == WarpZone.transform.position.x
				&& GvrMain.transform.position.z == WarpZone.transform.position.z;
			// 同じ位置でない場合、有効にする
			Particle.SetActive(!samePos);
		}
	}

	/// <summary>
	/// Update後にコールされるメソッド
	/// </summary>
	void LateUpdate()
	{
		// 状態の更新(backボタンの押下状態を更新する)
		GvrViewer.Instance.UpdateState();
		// backボタンが押されていた場合
		if (GvrViewer.Instance.BackButtonPressed)
		{
			// アプリケーションを終了する
			Application.Quit();
		}
	}
}
