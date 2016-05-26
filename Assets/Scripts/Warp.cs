using UnityEngine;
using System.Collections;
using System;

public class Warp : MonoBehaviour, IGvrGazeResponder
{
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
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
