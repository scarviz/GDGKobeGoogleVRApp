using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour
{
	[SerializeField]
	private GameObject MenuBtns;

	// Use this for initialization
	void Start ()
	{
		MenuBtns.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	/// <summary>
	/// 視線が当たった時の処理
	/// </summary>
	public void OnGazeEnter()
	{
		MenuBtns.SetActive(true);
	}

	/// <summary>
	/// 視線が外れた時の処理
	/// </summary>
	public void OnGazeExit()
	{
		MenuBtns.SetActive(false);
	}

	/// <summary>
	/// Settingsボタン押下時処理
	/// </summary>
	public void OnClick_BtnSettings()
	{
		Debug.Log("OnClick_BtnSettings");
	}
}
