using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class If_Yes_substance_upgreade : MonoBehaviour
{

    public Slider slider_smth;
    public Text smth;
    public Text speed;
    public Text max;
    public Button button;

    public float x = 50;
    public float y = 10;
    public float z = 50;
    public GameObject player;
    public GameObject cannot;
    public GameObject MaxLevel;

    void Start()
    {
        smth.text = string.Format("{0:0}", x * player.GetComponent<Player>().one_schet_substance);
        speed.text = string.Format("{0:0}", 10 + y * player.GetComponent<Player>().one_schet_substance);
        max.text = string.Format("{0:0}", 50 + z * player.GetComponent<Player>().one_schet_substance);
        button.onClick.AddListener(delegate { press(); });
    }

    public void press()
    {
        if (player.GetComponent<Player>().one_schet_substance < 6)
        {
            if (player.GetComponent<Player>().money >= x * player.GetComponent<Player>().one_schet_substance)
            {
                player.GetComponent<Player>().money -= x * player.GetComponent<Player>().one_schet_substance;
                //smth.text = string.Format("{0:0}", x*schet);
                player.GetComponent<Player>().one_schet_substance++;
                smth.text = string.Format("{0:0}", x * player.GetComponent<Player>().one_schet_substance);
                speed.text = string.Format("{0:0}", 10 + y * player.GetComponent<Player>().one_schet_substance);
                max.text = string.Format("{0:0}", 50 + z * player.GetComponent<Player>().one_schet_substance);
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
