using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;// ←new!

public class ButtonController : MonoBehaviour {

	public void toMainScene()
	{
		SceneManager.LoadScene(0);// ←new!
	}

}