using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class If_Yes_Upgreade : MonoBehaviour
{

    public Slider slider_smth;
    public Text smth;
    public Text speed;
    public Text max;
    public Button button;

    public float x = 50;
    public float y = 1;
    public float z = 5;
    public GameObject player;
    public GameObject cannot;
    public GameObject MaxLevel;

    void Start()
    {
        smth.text = string.Format("{0:0}", x * player.GetComponent<Player>().one_schet_fuel);
        speed.text = string.Format("{0:0}", 1 + y * player.GetComponent<Player>().one_schet_fuel);
        max.text = string.Format("{0:0}", 5 + z * player.GetComponent<Player>().one_schet_fuel);
        button.onClick.AddListener(delegate { press(); });
    }

    public void press()
    {
        if (player.GetComponent<Player>().one_schet_fuel < 6)
        {
            if (player.GetComponent<Player>().money >= x * player.GetComponent<Player>().one_schet_fuel)
            {
                player.GetComponent<Player>().money -= x * player.GetComponent<Player>().one_schet_fuel;
                //smth.text = string.Format("{0:0}", x*schet);
                player.GetComponent<Player>().one_schet_fuel++;
                smth.text = string.Format("{0:0}", x * player.GetComponent<Player>().one_schet_fuel);
                speed.text = string.Format("{0:0}", 1 + y * player.GetComponent<Player>().one_schet_fuel);
                max.text = string.Format("{0:0}", 5 + z * player.GetComponent<Player>().one_schet_fuel);
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