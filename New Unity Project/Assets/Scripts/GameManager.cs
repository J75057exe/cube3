using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameManager : MonoBehaviour {

    bool gameHasEnded = false;

    public float restartDelay = 1f;

    public float waitForLoad = 0.05f;

    public GameObject FailLevelUI;

    public GameObject completeLevelUI;

    public GameObject Lvl1Locked;

    public GameObject Lvl2Locked;

    public GameObject Lvl3Locked;

    public GameObject Lvl4Locked;

    public GameObject Lvl5Locked;

    public GameObject Lvl6Locked;

    public GameObject Lvl7Locked;

    public GameObject Lvl8Locked;

    public GameObject PauseMenu;


    void start ()
    {
        
    }

    public void CompleteLevel ()
    {
        completeLevelUI.SetActive(true);
        
    }

    public void FailLevel ()
    {
        FailLevelUI.SetActive(true);
    }

    public void ResetData()
    {
        PlayerPrefs.DeleteAll();
    }

    public void EndGame ()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("game over");
            FailLevel();
            Invoke("restart", restartDelay);
        }
    }
    public void restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
    }

    void FixedUpdate ()
    {

        if (Input.GetKey(KeyCode.Escape))
        {
            Debug.Log("you pressed esc");
            OpenMenu();
        }

        Lvl1Locked.SetActive(false);

        if (PlayerPrefs.GetInt("Level 1") == 1)
        {
            Lvl2Locked.SetActive(false);
        }
        else
        {
            Lvl2Locked.SetActive(true);
        }


        if (PlayerPrefs.GetInt("Level 2") == 1)
        {
            Lvl3Locked.SetActive(false);
        }
        else
        {
            Lvl3Locked.SetActive(true);
        }

        if (PlayerPrefs.GetInt("Level 3") == 1)
        {
            Lvl4Locked.SetActive(false);
        }
        else
        {
            Lvl4Locked.SetActive(true);
        }

        if (PlayerPrefs.GetInt("Level 4") == 1)
        {
            Lvl5Locked.SetActive(false);
        }
        else
        {
            Lvl5Locked.SetActive(true);
        }

        if (PlayerPrefs.GetInt("Level 5") == 1)
        {
            Lvl6Locked.SetActive(false);
        }
        else
        {
            Lvl6Locked.SetActive(true);
        }

        if (PlayerPrefs.GetInt("Level 6") == 1)
        {
            Lvl7Locked.SetActive(false);
        }
        else
        {
            Lvl7Locked.SetActive(true);
        }

        if (PlayerPrefs.GetInt("Level 7") == 1)
        {
            Lvl8Locked.SetActive(false);
        }
        else
        {
            Lvl8Locked.SetActive(true);
        }

    }

    public void OpenMenu ()
    {

        
        PauseMenu.SetActive(true);
        Debug.Log("you paused the game");
        Time.timeScale = 0f;
        //time.fixedDeltaTime = 0f;
        
    }

    public void CloseMenu ()
    {
        PauseMenu.SetActive(false);
        Debug.Log("you unpaused the game");
        Time.timeScale = 1f;
        //Time.fixedDeltaTime = 1f;
        //start();
    }

    public void GameQuit ()
    {
        Application.Quit();
        Debug.Log("quit");
    }

    public void MainMenu ()
    {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1f;
    }

    public void PlayLevel1()
    {
        SceneManager.LoadScene("Level 1");
     
    }

    public void PlayLevel2()
    {
        if (PlayerPrefs.GetInt("Level 1") == 1)
            SceneManager.LoadScene("Level 2");
    }

    public void PlayLevel3()
    {
        if (PlayerPrefs.GetInt("Level 2") == 1)
        {
            SceneManager.LoadScene("Level 3");
        }

    }

    public void PlayLevel4()
    {
        if (PlayerPrefs.GetInt("Level 3") == 1)
        {
            SceneManager.LoadScene("Level 4");
        }

    }

    public void PlayLevel5()
    {
        if (PlayerPrefs.GetInt("Level 4") == 1)
        {
            SceneManager.LoadScene("Level 5");
        }
            
    }

    public void PlayLevel6()
    {
        if (PlayerPrefs.GetInt("Level 5") == 1)
        {
            SceneManager.LoadScene("Level 6");
        }
    }

    public void PlayLevel7()
    {
        if (PlayerPrefs.GetInt("Level 6") == 1)
        {
            SceneManager.LoadScene("Level 7");
        }
    }

    public void PlayLevel8()
    {
        if (PlayerPrefs.GetInt("Level 7") == 1)
        {
            SceneManager.LoadScene("Level 8");
        }
    }

}

