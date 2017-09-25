using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PanelScript : MonoBehaviour {
	public AudioSource clickButton;

    public void Retry()
    {
		clickButton.Play ();
        SceneManager.LoadScene("Minigame");
    }

	public void NextLevel()
	{
		clickButton.Play ();
		SceneManager.LoadScene("Level2");
	}
}
