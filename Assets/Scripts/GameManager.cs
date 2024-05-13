using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TMP_Text PlayerName;
    // Start is called before the first frame update
    void Start()
    {
        PlayerName.text = PlayerPrefs.GetString("PlayerName");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
