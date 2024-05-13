using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TMP_Text PlayerName;
    public GameObject Player1;
    public GameObject Player2;

    // Start is called before the first frame update
    void Start()
    {
        PlayerName.text = PlayerPrefs.GetString("PlayerName");
        if(PlayerPrefs.GetInt("PlayerNum") == 2)
        {
            Player1.active = false;
            Player2.active = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
