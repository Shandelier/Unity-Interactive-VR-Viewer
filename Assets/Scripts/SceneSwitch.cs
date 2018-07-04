using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour {

	public void OpenVenus()
	{
		SceneManager.LoadScene("SceneVenus");
	}

	public void OpenTV()
	{
		SceneManager.LoadScene("SceneTV");
	}

	public void OpenRocket()
	{
		SceneManager.LoadScene("SceneRocket");
	}

	public void OpenBase()
	{
		SceneManager.LoadScene("SceneBase");
	}
}
