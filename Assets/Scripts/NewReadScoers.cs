using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System;
using System.Linq;

public class NewReadScoers : MonoBehaviour
{
    [SerializeField] Text txt_onename;

    string[] newArray = new string[10];
    string myNewFilePath, newfileName;

    string showmyname = NameTransfer.theName;

    int i;

    public GameObject displayText;

    void Start()
    {
        newfileName = "scores.txt";
        myNewFilePath = Application.dataPath + "/" + newfileName;
        NewReadFromTheFile();
    }

    void DisplayOneScore()
    {
        System.Array.Sort(newArray);
        Array.Reverse(newArray);
        foreach (string line in newArray)
        {
            txt_onename.text += line + "\n";
        }

    }

    public void NewReadFromTheFile()
    {
        var LastLine = File.ReadLines(myNewFilePath).Last();
        displayText.GetComponent<Text>().text = showmyname.ToUpper() + "\n" + "Your score this round was " + LastLine + "!";
        DisplayOneScore();
    }
}
