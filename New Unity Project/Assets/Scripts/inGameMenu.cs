using UnityEngine;

public class inGameMenu : MonoBehaviour {

	
	// Update is called once per frame
	void FixedUpdate ()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Debug.Log("you pressed esc");
            OpenMenu ();
        }

    }

    public void OpenMenu ()
    {
        Debug.Log("you paused the game");
    }
}
