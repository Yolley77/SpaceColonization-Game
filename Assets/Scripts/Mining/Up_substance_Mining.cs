using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Up_substance_Mining : MonoBehaviour {

    public GameObject player;
    public float timer = 6f;
    private float timerDown;

    // Use this for initialization
    void Start () {
        timerDown = timer / player.GetComponent<Player>().one_schet_substance;
	}
	
	// Update is called once per frame
	void Update () {
		if (timerDown < 0)
        {
            if (player.GetComponent<Player>().one_substance_value < 50 * player.GetComponent<Player>().one_schet_substance)
            {
                player.GetComponent<Player>().one_substance_value++;
            }
            timerDown = timer / player.GetComponent<Player>().one_schet_substance;
        }
        else
        {
            timerDown -= Time.deltaTime;
        }
	}
}
