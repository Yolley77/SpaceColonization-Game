﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class valuesss : MonoBehaviour {

    public Text progtext;
    public GameObject player;

	void Update () {
        progtext.text = string.Format("{0:0}", player.GetComponent<Player>().money);
    }
}
