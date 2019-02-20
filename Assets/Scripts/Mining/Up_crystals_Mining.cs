using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Up_crystals_Mining : MonoBehaviour {

    public GameObject player;
    public float timer = 12f;
    private float timerDown;

    // Use this for initialization
    void Start () {
        timerDown = timer / player.GetComponent<Player>().one_schet_crystals;
	}
	
	// Update is called once per frame
	void Update () {
		if (timerDown < 0)
        {
            if (player.GetComponent<Player>().one_crystals_value < 25 * player.GetComponent<Player>().one_schet_crystals)
            {
                player.GetComponent<Player>().one_crystals_value++;
            }
            timerDown = timer / player.GetComponent<Player>().one_schet_crystals;
        }
        else
        {
            timerDown -= Time.deltaTime;
        }
	}
}
