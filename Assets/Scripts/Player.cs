using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {
    public float expirience;
    public float money;
    public float crystals;
    public float fuel;
    public float substance;

    public int flag;
    public int q_flag = 0;
    public int level_value = 1;
    public int proverka2 = 0;
    public int proverka3 = 0;
    public int ura = 0;
    public int torgovla2 = 0;
    public int begin_proverka;

    public GameObject player;

    public GameObject mining_crystals;
    public GameObject up_crystals_mining;
    public GameObject mining_fuel;
    public GameObject up_fuel_mining;
    public GameObject mining_substance;
    public GameObject up_substance_mining;

    public float one_schet_fuel;
    public float one_schet_crystals;
    public float one_schet_substance;
    public float one_crystals_value;
    public float one_fuel_value;
    public float one_substance_value;

    public void Start()
    {
        if(Application.loadedLevel == 4)
        {
            Screen.SetResolution(1024, 600, true);
        }

        if (Application.loadedLevel == 3)
        {
            Screen.SetResolution(1024, 600, true);
        }

        if (Application.loadedLevel == 1)
        {
            Screen.SetResolution(1024, 600, true);
        }

        Screen.SetResolution(1024, 600, true); // IDK WHY?!?!?!?!!?

        if (one_schet_crystals == 1)
        {
            mining_crystals.SetActive(true);
        }
        if (one_schet_fuel == 1)
        {
            mining_fuel.SetActive(true);
        }
        if (one_schet_substance == 1)
        {
            mining_substance.SetActive(true);
        }

        if (one_schet_crystals > 1)
        {
            up_crystals_mining.SetActive(true);
        }
        if (one_schet_fuel > 1)
        {
            up_fuel_mining.SetActive(true);
        }
        if (one_schet_substance > 1)
        {
            up_substance_mining.SetActive(true);
        }

    }

    public void Update()
    {
        if (Application.loadedLevel == 1) // ВОСХИЩАЙТЕСЬ ШЕДЕВРОМ!!!
        {
            Screen.SetResolution(1024, 600, true);
        }

        if (PlayerPrefs.GetInt("flag") == 0)
        {
            PlayerPrefs.SetInt("begin_proverka", 0);
            PlayerPrefs.SetInt("flag", 1);
            PlayerPrefs.SetInt("q_flag", 0);
            PlayerPrefs.SetInt("level_value", 1);
            PlayerPrefs.SetInt("proverka2", 0);
            PlayerPrefs.SetInt("proverka3", 0);
            PlayerPrefs.SetInt("ura", 0);
            PlayerPrefs.SetInt("torgovla2", 0);
            

            PlayerPrefs.SetFloat("expirience", 950);
            PlayerPrefs.SetFloat("money", 900);
            PlayerPrefs.SetFloat("crystals", 66);
            PlayerPrefs.SetFloat("fuel", 15);
            PlayerPrefs.SetFloat("substance", 50);

            PlayerPrefs.SetFloat("one_schet_fuel", 0);
            PlayerPrefs.SetFloat("one_schet_crystals", 0);
            PlayerPrefs.SetFloat("one_schet_substance", 0);
            PlayerPrefs.SetFloat("one_crystals_value", 0);
            PlayerPrefs.SetFloat("one_fuel_value", 0);
            PlayerPrefs.SetFloat("one_substance_value", 0);

            begin_proverka = PlayerPrefs.GetInt("begin_proverka");
            flag = PlayerPrefs.GetInt("flag");
            q_flag = PlayerPrefs.GetInt("q_flag");
            level_value = PlayerPrefs.GetInt("level_value");
            proverka2 = PlayerPrefs.GetInt("proverka2");
            proverka3 = PlayerPrefs.GetInt("proverka3");
            ura = PlayerPrefs.GetInt("ura");
            torgovla2 = PlayerPrefs.GetInt("torgovla2");
            

            expirience = PlayerPrefs.GetFloat("expirience");
            money = PlayerPrefs.GetFloat("money");
            crystals = PlayerPrefs.GetFloat("crystals");
            fuel = PlayerPrefs.GetFloat("fuel");
            substance = PlayerPrefs.GetFloat("substance");
            one_schet_fuel = PlayerPrefs.GetFloat("one_schet_fuel");
            one_schet_crystals = PlayerPrefs.GetFloat("one_schet_crystals");
            one_schet_substance = PlayerPrefs.GetFloat("one_schet_substance");
            one_crystals_value = PlayerPrefs.GetFloat("one_crystals_value");
            one_fuel_value = PlayerPrefs.GetFloat("one_fuel_value");
            one_substance_value = PlayerPrefs.GetFloat("one_substance_value");
        }
    }
}
