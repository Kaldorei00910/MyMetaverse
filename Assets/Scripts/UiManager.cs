using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour
{
    private void Awake()
    {
        //DontDestroyOnLoad(gameObject);
    }

    public void ChangeNameWithScene(string name)
    {
        SceneManager.LoadScene("SampleScene");
        PlayerPrefs.SetString("PlayerName", name);
    }
}
