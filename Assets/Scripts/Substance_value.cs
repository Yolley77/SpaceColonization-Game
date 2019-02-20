using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Substance_value : MonoBehaviour {

    public Text progtext;
    public GameObject player;

	
	// Update is called once per frame
	void Update () {
        progtext.text = string.Format("{0:0}", player.GetComponent<Player>().one_substance_value);
    }
}
