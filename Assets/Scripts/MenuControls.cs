using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControls : MonoBehaviour {
    public GameObject player;

    public void ContinuePressed()
    {
        SceneManager.LoadScene("LoadingScene");
    }

    public void NewPressed()
    {
        player.GetComponent<Player>().flag = 0;
        SceneManager.LoadScene("LoadingScene");
    }

    public void ExitPressed()
    {
        Application.Quit();
        Debug.Log("Exit Pressed!");
    }
}
