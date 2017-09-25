using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour {
	public AudioSource clickB;

    public string mainGameScene; 
	public string HelpScene;
     
	public void Play()
    {
		clickB.Play();
        SceneManager.LoadScene(mainGameScene);
    }
    public void Score()
    {
		clickB.Play ();
    }
    public void Settings()
    {
		clickB.Play ();
    }
    public void Help()
    {
		clickB.Play ();
		SceneManager.LoadScene(HelpScene);
    }

}
