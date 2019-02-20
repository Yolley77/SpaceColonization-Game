using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Begin_galaxy : MonoBehaviour {

    public GameObject player;
    public GameObject Begin_img;


	void Update () {                    // WTF, WHY UPDATE&!&!&!
        if (player.GetComponent<Player>().begin_proverka == 0)
        {
            Begin_img.SetActive(true);
            player.GetComponent<Player>().begin_proverka = 1;
        }
    }

}
