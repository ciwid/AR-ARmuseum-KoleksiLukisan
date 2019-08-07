using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class buttonManager : MonoBehaviour {
	
    void Start()
    {

    }

	void Update(){
		if (Input.GetKeyDown(KeyCode.Escape)) { Application.Quit(); }
	}

    public void LoadScene(string scenename)
    {
		SceneManager.LoadScene (scenename);
    }
    

    public void ExitGame()
    {
		#if UNITY_EDITOR
		        UnityEditor.EditorApplication.isPlaying = false;
		#else
		        Application.Quit ();
		#endif
    }
		
}