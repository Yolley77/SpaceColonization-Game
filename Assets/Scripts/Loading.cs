using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loading : MonoBehaviour {

    public GameObject player;

    void Start () {
        Load();
	}

    public void Load()
    {
        player.GetComponent<Player>().begin_proverka = PlayerPrefs.GetInt("begin_proverka");
        player.GetComponent<Player>().flag = PlayerPrefs.GetInt("flag");
        player.GetComponent<Player>().q_flag = PlayerPrefs.GetInt("q_flag");
        player.GetComponent<Player>().level_value = PlayerPrefs.GetInt("level_value");
        player.GetComponent<Player>().proverka2 = PlayerPrefs.GetInt("proverka2");
        player.GetComponent<Player>().proverka3 = PlayerPrefs.GetInt("proverka3");
        player.GetComponent<Player>().ura = PlayerPrefs.GetInt("ura");
        player.GetComponent<Player>().torgovla2 = PlayerPrefs.GetInt("torgovla2");
        

        player.GetComponent<Player>().expirience = PlayerPrefs.GetFloat("expirience");
        player.GetComponent<Player>().money = PlayerPrefs.GetFloat("money");
        player.GetComponent<Player>().crystals = PlayerPrefs.GetFloat("crystals");
        player.GetComponent<Player>().fuel = PlayerPrefs.GetFloat("fuel");
        player.GetComponent<Player>().substance = PlayerPrefs.GetFloat("substance");
        player.GetComponent<Player>().one_schet_fuel = PlayerPrefs.GetFloat("one_schet_fuel");
        player.GetComponent<Player>().one_schet_crystals = PlayerPrefs.GetFloat("one_schet_crystals");
        player.GetComponent<Player>().one_schet_substance = PlayerPrefs.GetFloat("one_schet_substance");
        player.GetComponent<Player>().one_crystals_value = PlayerPrefs.GetFloat("one_crystals_value");
        player.GetComponent<Player>().one_fuel_value = PlayerPrefs.GetFloat("one_fuel_value");
        player.GetComponent<Player>().one_substance_value = PlayerPrefs.GetFloat("one_substance_value");

        Debug.Log("Load!");
    }
}
