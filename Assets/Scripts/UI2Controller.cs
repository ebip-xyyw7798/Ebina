using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class UI2Controller : MonoBehaviour 
{
	public Text GameOverLabel;

	private void Start () 
	{
		// 開始時に表示を消す
		GameOverLabel.gameObject.SetActive(false);	
	}

	public void ShowGameOverLabel()
	{
		// 開始時に表示する
		GameOverLabel.gameObject.SetActive(true);	
	}
}