using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Check_mark : MonoBehaviour {

    public GameObject player;
    public GameObject mark1;
    public GameObject mark2;
    public GameObject mark3;
    public GameObject image;
    //public GameObject URA;
    public GameObject ura_img;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (player.GetComponent<Player>().q_flag == 0 && player.GetComponent<Player>().one_schet_fuel == 6 && player.GetComponent<Player>().one_schet_crystals == 6 && player.GetComponent<Player>().one_schet_substance == 6)
        {
            mark1.SetActive(true);
            player.GetComponent<Player>().expirience += 100;
            player.GetComponent<Player>().q_flag = 1;
            image.SetActive(true);
        }

        if (player.GetComponent<Player>().q_flag == 1)
        {
            mark2.SetActive(true);
        }

        if (player.GetComponent<Player>().proverka2 == 0 && player.GetComponent<Player>().torgovla2 == 1)
        {
            image.SetActive(true);
            mark2.SetActive(true);
            player.GetComponent<Player>().expirience += 100;
            player.GetComponent<Player>().proverka2 = 1;
        }

        if (player.GetComponent<Player>().proverka2 == 1)
        {
            mark2.SetActive(true);
        }

        if (player.GetComponent<Player>().fuel == 100 && player.GetComponent<Player>().proverka3 == 0)
        {
            image.SetActive(true);
            mark3.SetActive(true);
            player.GetComponent<Player>().expirience += 100;
            player.GetComponent<Player>().proverka3 = 1;
        }

        if (player.GetComponent<Player>().proverka3 == 1)
        {
            mark3.SetActive(true);
        }

        //if (mark1.active == true && mark2.active == true && mark3.active == true && player.GetComponent<Player>().ura == 0)
        if (player.GetComponent<Player>().torgovla2 == 1 && player.GetComponent<Player>().fuel == 100 && 
            player.GetComponent<Player>().one_schet_fuel == 6 && player.GetComponent<Player>().one_schet_crystals == 6 && 
            player.GetComponent<Player>().one_schet_substance == 6 && player.GetComponent<Player>().ura == 0)
        {
            ura_img.SetActive(true);
            player.GetComponent<Player>().ura = 1;
        }

    }
}
