using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectButton : MonoBehaviour {

    public Button button;
    public GameObject player;

    void Start () {
        button.onClick.AddListener(delegate { press(); });
    }
	

    public void press()
    {
        if (player.GetComponent<Player>().crystals != 1000 && player.GetComponent<Player>().one_crystals_value != 0)
        {
            while (player.GetComponent<Player>().crystals != 1000 && player.GetComponent<Player>().one_crystals_value != 0)
            {
                player.GetComponent<Player>().crystals += 1;
                player.GetComponent<Player>().one_crystals_value -= 1;
            }
        }

        if (player.GetComponent<Player>().fuel != 100 && player.GetComponent<Player>().one_fuel_value != 0)
        {
            while (player.GetComponent<Player>().fuel != 100 && player.GetComponent<Player>().one_fuel_value != 0)
            {
                player.GetComponent<Player>().fuel += 1;
                player.GetComponent<Player>().one_fuel_value -= 1;
            }
        }

        if (player.GetComponent<Player>().substance != 1000 && player.GetComponent<Player>().one_substance_value != 0)
        {
            while (player.GetComponent<Player>().substance != 1000 && player.GetComponent<Player>().one_substance_value != 0)
            {
                player.GetComponent<Player>().substance += 1;
                player.GetComponent<Player>().one_substance_value -= 1;
            }
        }
    }
}
