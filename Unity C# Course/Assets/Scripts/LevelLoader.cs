using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelLoader : MonoBehaviour {

    public int sceneNumber;

	// Use this for initialization
	void Start () {
        print(" Level Loaded");
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDown(0))
        {
            //LoadLevel();

            RestartLevel();

        }

	}


    void LoadLevel()
    {
        //SceneManager.LoadScene("level2");
        //SceneManager.LoadScene(sceneNumber);



    }

    void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
