using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class timeTime : MonoBehaviour
{
    public GameObject hint;

    public Transform player;

    void start()
    {
        
    }

    public void openUI ()
    {
        hint.SetActive(true);
        Invoke("closeUI", 2);
    }

    public void closeUI()
    {
        hint.SetActive(false);
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Time.timeScale = 0.2f;
            //Time.fixedDeltaTime = 0.02f * Time.timeScale;

        }

        if (Input.GetKey(KeyCode.Space) == false)
        {
            Time.timeScale = 1.0f;
            //Time.fixedDeltaTime = 0.02f * Time.timeScale;
        }

        if (player.position.z > 0)
        {
            openUI();
        }
    }








}
