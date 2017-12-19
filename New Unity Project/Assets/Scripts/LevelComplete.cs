using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour {

    public void LoadNextLevel ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        PlayerPrefs.SetInt(SceneManager.GetActiveScene().name, 1);
        Debug.Log(PlayerPrefs.GetInt(SceneManager.GetActiveScene().name));

    }

}
