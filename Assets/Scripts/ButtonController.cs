using JetBrains.Annotations;
using System.Runtime.CompilerServices;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonController : UiManager
{
    public TMP_Text text;
    public void OnOKButton()
    { 
        ChangeNameWithScene(text.text);
    }
}