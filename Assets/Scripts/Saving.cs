using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saving : MonoBehaviour {

    public GameObject player;

    public void Save()
    {
        PlayerPrefs.SetInt("begin_proverka", player.GetComponent<Player>().begin_proverka);
        PlayerPrefs.SetInt("flag", player.GetComponent<Player>().flag);
        PlayerPrefs.SetInt("q_flag", player.GetComponent<Player>().q_flag);
        PlayerPrefs.SetInt("level_value", player.GetComponent<Player>().level_value);
        PlayerPrefs.SetInt("proverka2", player.GetComponent<Player>().proverka2);
        PlayerPrefs.SetInt("proverka3", player.GetComponent<Player>().proverka3);
        PlayerPrefs.SetInt("ura", player.GetComponent<Player>().ura);
        PlayerPrefs.SetInt("torgovla2", player.GetComponent<Player>().torgovla2);
        

        PlayerPrefs.SetFloat("expirience", player.GetComponent<Player>().expirience);
        PlayerPrefs.SetFloat("money", player.GetComponent<Player>().money);
        PlayerPrefs.SetFloat("crystals", player.GetComponent<Player>().crystals);
        PlayerPrefs.SetFloat("fuel", player.GetComponent<Player>().fuel);
        PlayerPrefs.SetFloat("substance", player.GetComponent<Player>().substance);
        PlayerPrefs.SetFloat("one_schet_fuel", player.GetComponent<Player>().one_schet_fuel);
        PlayerPrefs.SetFloat("one_schet_crystals", player.GetComponent<Player>().one_schet_crystals);
        PlayerPrefs.SetFloat("one_schet_substance", player.GetComponent<Player>().one_schet_substance);
        PlayerPrefs.SetFloat("one_crystals_value", player.GetComponent<Player>().one_crystals_value);
        PlayerPrefs.SetFloat("one_fuel_value", player.GetComponent<Player>().one_fuel_value);
        PlayerPrefs.SetFloat("one_substance_value", player.GetComponent<Player>().one_substance_value);

        PlayerPrefs.Save();
        Debug.Log("Save!");
    }

}
