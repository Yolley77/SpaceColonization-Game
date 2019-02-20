using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slider_three : MonoBehaviour
{

    public Slider slid;
    public Text progtext;
    public GameObject player;

    void Update()
    {
        if (player.GetComponent<Player>().expirience >= 0)
        {
            slid.value = player.GetComponent<Player>().expirience;
            progtext.text = string.Format("{0:0}", slid.value);
        }
    }
}
