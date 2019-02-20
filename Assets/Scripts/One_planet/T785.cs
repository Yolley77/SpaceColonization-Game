using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class T785 : MonoBehaviour
{
    public Button button;

    public GameObject player;
    public GameObject crystals;
    public GameObject crystals_up;
    public GameObject fuel;
    public GameObject fuel_up;
    public GameObject substance;
    public GameObject substance_up;

    void Start()
    {
        button.onClick.AddListener(delegate { press(); });
    }

    public void press()
    {
        if (player.GetComponent<Player>().one_schet_crystals == 0)
        {
            crystals.active = true;
        }
        else
        {
            crystals.active = false;
            crystals_up.active = true;
        }

        if (player.GetComponent<Player>().one_schet_fuel == 0)
        {
            fuel.active = true;
        }
        else
        {
            fuel.active = false;
            fuel_up.active = true;
        }

        if (player.GetComponent<Player>().one_schet_substance == 0)
        {
            substance.active = true;
        }
        else
        {
            substance.active = false;
            substance_up.active = true;
        }
    }
}