using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.IO;
using UnityEditor;
using UnityEngine.SceneManagement;

public class DisplayName : MonoBehaviour
{
    string showmyname = NameTransfer.theName;
    public GameObject displayText;
    //private int playerScore = frog.newScore;
    public Text writeScore;
    private int newScore = Score.CurrentScore;

    public void Start()
    {
        displayText.GetComponent<Text>().text = showmyname.ToUpper() + "\n" + "Your score this round was " + newScore + "!";

    }
}
