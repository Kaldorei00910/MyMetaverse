using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    public Sprite pgnImage;
    public Sprite sushiImage;
    public GameObject ChangeBtn;

    private void Awake()
    {
        PlayerPrefs.SetInt("PlayerNum", 1);
        PlayerPrefs.SetString("PlayerName", "John Doe");
    }

    public void ChangeNameWithScene(string name)
    {
        SceneManager.LoadScene("SampleScene");
        PlayerPrefs.SetString("PlayerName", name);
    }
    public void ChangeChar(string name)
    {
        if (name == "Player2Image")
        {
            PlayerPrefs.SetInt("PlayerNum", 2);
            ChangeBtn.GetComponent<Image>().sprite = sushiImage;
        }
        else
        {
            PlayerPrefs.SetInt("PlayerNum", 1);
            ChangeBtn.GetComponent<Image>().sprite = pgnImage;

        }
    }
}

