using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    public void OnPlayButtonPressed()
    {
        PlayerPrefs.SetInt("TimeToLoad", 0);//new
        PlayerPrefs.Save();
        SceneManager.LoadScene("SampleScene");
    }
}