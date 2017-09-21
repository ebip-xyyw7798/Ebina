using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class UI3Controller : MonoBehaviour 
{
	public Button button;

	private void Start () 
	{
		// 開始時に表示を消す
		button.gameObject.SetActive(false);	
	}

	public void Button()
	{
		// 開始時に表示する
		button.gameObject.SetActive(true);	
	}
}