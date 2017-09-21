using System.Collections;
using UnityEngine;

public class RetryController : MonoBehaviour 
{
	// UIController を参照する
	public UI3Controller UI3Controller;

	// Trigger との接触時に呼ばれる Callback
	private void OnTriggerEnter (Collider hit)
	{
		// 接触対象はPlayerタグかどうか
		if (hit.CompareTag ("Player")) 
		{
			// Rigidbody を停止させる
			hit.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;

			// ゲームクリアを表示する
			UI3Controller.Button();
		}
	}
}