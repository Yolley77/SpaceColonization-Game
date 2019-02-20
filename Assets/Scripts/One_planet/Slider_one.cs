using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slider_one : MonoBehaviour
{

    public Slider slid;
    public Text progtext;
    public GameObject player;

    void Update()
    {
        if (player.GetComponent<Player>().fuel >= 0)
        {
            slid.value = player.GetComponent<Player>().fuel;
            progtext.text = string.Format("{0:0}", slid.value);
        }
    }
}
