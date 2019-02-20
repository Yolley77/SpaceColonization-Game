using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MaxLevel_fuel : MonoBehaviour {

    public GameObject player;
    public GameObject nextScene;
    public GameObject MaxLevel;
    public Button button;

    void Start () {
        button.onClick.AddListener(delegate { press(); });
    }

    public void press()
    {
        if (player.GetComponent<Player>().one_schet_fuel < 5)
        {
            nextScene.active = true;
        }
        else
        {
            MaxLevel.active = true;
        }
    }
}
