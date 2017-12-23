using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

    public void StartGame ()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void LevelSelect ()
    {
        SceneManager.LoadScene("Levels");
        Time.timeScale = 1f;
    }

    public void DisplayInst ()
    {
        SceneManager.LoadScene("Instructions");
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("quit");
    }


}
