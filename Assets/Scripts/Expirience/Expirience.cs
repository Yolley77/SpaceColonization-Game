using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Expirience : MonoBehaviour {

    public GameObject player;
    public GameObject image;

	void Update () {
		if (player.GetComponent<Player>().q_flag == 0 && player.GetComponent<Player>().one_schet_fuel == 6 && player.GetComponent<Player>().one_schet_crystals == 6 && player.GetComponent<Player>().one_schet_substance == 6)
        {
            player.GetComponent<Player>().expirience += 100;
            player.GetComponent<Player>().q_flag = 1;

            image.SetActive(true);
        } 
	}
}
