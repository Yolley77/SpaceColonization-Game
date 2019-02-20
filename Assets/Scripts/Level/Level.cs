using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level : MonoBehaviour {

    public Text level_text;
    public GameObject player;

	void Start () {
        level_text.text = string.Format("{0:0}", player.GetComponent<Player>().level_value);
    }
	
	void Update () {
		if (player.GetComponent<Player>().expirience >= 1000)
        {
            player.GetComponent<Player>().expirience -= 1000;
            player.GetComponent<Player>().level_value++;
            level_text.text = string.Format("{0:0}", player.GetComponent<Player>().level_value);
        }
	}
}
