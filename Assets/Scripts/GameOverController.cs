using System.Collections;
using UnityEngine;

public class GameOverController : MonoBehaviour 
{
	// UIController を参照する
	public UI2Controller UI2Controller;

	// Trigger との接触時に呼ばれる Callback
	private void OnTriggerEnter (Collider hit)
	{
		// 接触対象はPlayerタグかどうか
		if (hit.CompareTag ("Player")) 
		{
			// Rigidbody を停止させる
			hit.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;

			// ゲームクリアを表示する
			UI2Controller.ShowGameOverLabel();
		}
	}
}