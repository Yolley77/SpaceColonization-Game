using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Value_in_text : MonoBehaviour {

    public int value;
    public Text text_value;
	
	// Update is called once per frame
	void Update () {
        text_value.text = string.Format("{0:0}", value);
	}
}
