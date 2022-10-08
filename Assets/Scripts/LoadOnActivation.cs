using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadOnActivation : MonoBehaviour
{
    public void PlayGame()
    {
            SceneManager.LoadScene("Play Test");

    }
}