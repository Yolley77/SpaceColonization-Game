using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Up_fuel_Mining : MonoBehaviour {

    public GameObject player;
    public float timer = 60f;
    private float timerDown;

    // Use this for initialization
    void Start () {
        timerDown = timer / player.GetComponent<Player>().one_schet_fuel;
	}
	
	// Update is called once per frame
	void Update () {
		if (timerDown < 0)
        {
            if (player.GetComponent<Player>().one_fuel_value < 5 * player.GetComponent<Player>().one_schet_fuel)
            {
                player.GetComponent<Player>().one_fuel_value++;
            }
            timerDown = timer / player.GetComponent<Player>().one_schet_fuel;
        }
        else
        {
            timerDown -= Time.deltaTime;
        }
	}
}
