using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class If_Yes_crystals_upgreade : MonoBehaviour
{

    public Slider slider_smth;
    public Text smth;
    public Text speed;
    public Text max;
    public Button button;

    public float x = 50;
    public float y = 5;
    public float z = 25;
    public GameObject player;
    public GameObject cannot;
    public GameObject MaxLevel;

    void Start()
    {
        smth.text = string.Format("{0:0}", x * player.GetComponent<Player>().one_schet_crystals);
        speed.text = string.Format("{0:0}", 5 + y * player.GetComponent<Player>().one_schet_crystals);
        max.text = string.Format("{0:0}", 25 + z * player.GetComponent<Player>().one_schet_crystals);
        button.onClick.AddListener(delegate { press(); });
    }

    public void press()
    {
        if (player.GetComponent<Player>().one_schet_crystals < 6)
        {
            if (player.GetComponent<Player>().money >= x * player.GetComponent<Player>().one_schet_crystals)
            {
                player.GetComponent<Player>().money -= x * player.GetComponent<Player>().one_schet_crystals;
                player.GetComponent<Player>().one_schet_crystals++;
                smth.text = string.Format("{0:0}", x * player.GetComponent<Player>().one_schet_crystals);
                speed.text = string.Format("{0:0}", 5 + y * player.GetComponent<Player>().one_schet_crystals);
                max.text = string.Format("{0:0}", 25 + z * player.GetComponent<Player>().one_schet_crystals);
            }
            else
            {
                cannot.active = true;
            }
        }
        else
        {
            MaxLevel.active = true;
        }
    }
}