using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class C_23i : MonoBehaviour
{

    public GameObject player;
    public GameObject enemy_text;
    public GameObject info_text;
    public GameObject norm_text;
    public GameObject torgovla_button;
    public GameObject GObutton_700;
    public Button button_700;
    
    void Start()
    {
        if (player.GetComponent<Player>().torgovla2 == 0)
        {
            enemy_text.SetActive(true);
            info_text.SetActive(true);
            GObutton_700.SetActive(true);
            norm_text.SetActive(false);
            torgovla_button.SetActive(false);
        }

        if (player.GetComponent<Player>().torgovla2 == 1)
        {
            torgovla_button.SetActive(true);
            enemy_text.SetActive(false);
            info_text.SetActive(false);
            norm_text.SetActive(true);
            GObutton_700.SetActive(false);
        }
        button_700.onClick.AddListener(delegate { press(); });
    }

    public void press()
    {
        if (player.GetComponent<Player>().money >= 700)
        {
            player.GetComponent<Player>().money -= 700;
            player.GetComponent<Player>().torgovla2 = 1;
            torgovla_button.SetActive(true);
            enemy_text.SetActive(false);
            info_text.SetActive(false);
            norm_text.SetActive(true);
            GObutton_700.SetActive(false);
        }
    }
}
