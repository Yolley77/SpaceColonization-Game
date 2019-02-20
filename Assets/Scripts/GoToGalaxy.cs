using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToGalaxy : MonoBehaviour {
    public void GalaxyMapPressed()
    {
        SceneManager.LoadScene("Galaxy");
    }
}
