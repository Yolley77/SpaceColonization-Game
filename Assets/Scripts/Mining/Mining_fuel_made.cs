using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mining_fuel_made : MonoBehaviour {

    public GameObject player;
    public float timer = 60f;
    private float timerDown;

    // Use this for initialization
    void Start () {
        timerDown = timer;
	}
	
	// Update is called once per frame
	void Update () {
		if (timerDown < 0)
        {
            if (player.GetComponent<Player>().one_fuel_value < 5)
            {
                player.GetComponent<Player>().one_fuel_value++;
            }
            timerDown = timer;
        }
        else
        {
            timerDown -= Time.deltaTime;
        }
	}
}
