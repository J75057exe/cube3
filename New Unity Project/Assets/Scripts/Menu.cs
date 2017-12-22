using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

    public GameObject Oroka;

    public GameObject fakeOroka;

    public void Enter()
    {
        Invoke("closeOroka", 1);
        Oroka.SetActive(true);
        fakeOroka.SetActive(false);
    }

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

    public void closeOroka()
    {
        Oroka.SetActive(false);
    }


}
