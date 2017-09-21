using System.Collections;
using UnityEngine;

public class PlayerController : MonoBehaviour 
{
	private void FixedUpdate ()
	{
		float x = Input.GetAxis("Horizontal");
		float z = Input.GetAxis("Vertical");

		// Player が持つ Rigidbody コンポーネントを取得
		Rigidbody rigidbody = GetComponent<Rigidbody>();

		// rigidbodyのx軸（横）とz軸（奥）に 5 倍の力を加える
		rigidbody.AddForce(x * 8, 0, z * 8);

		if (Input.GetKeyDown ("space"))
			rigidbody.AddForce (Vector3.up * 150);

		if(Input.GetKey(KeyCode.X))
			rigidbody.velocity = Vector3.zero;
	}
}