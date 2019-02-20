using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class If_Yes_crystals : MonoBehaviour
{

    public Slider slider_smth;
    public Text smth;
    public Button button;

    public float x = 50;
    public GameObject player;
    public GameObject cannot;

    void Start()
    {
        button.onClick.AddListener(delegate { press(); });
    }

    public void press()
    {
        if (player.GetComponent<Player>().money >= x)
        {
            player.GetComponent<Player>().money -= x;
            player.GetComponent<Player>().one_schet_crystals++;
        }
        else
        {
            cannot.active = true;
        }
    }
}