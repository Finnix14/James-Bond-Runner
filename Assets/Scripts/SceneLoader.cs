using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    private void Start()
    {
        Time.timeScale = 1;
    }

    public void LoadLevel()
    {

        SceneManager.LoadScene("Cinematic");
    }


}
