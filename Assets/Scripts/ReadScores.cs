using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System;
using System.Linq;

public class ReadScores : MonoBehaviour
{
    /* public Text HighScores;
    public int num_scores = 10;

    public void ShowTopScores()
    {
        string path = "Assets/scores.txt";
        string line;
        string[] fields;
        string[] playerNames = new string[num_scores];
        int[] playerScores = new int[num_scores];
        int scores_read = 0;

        //HighScores.text = ""; // clear the scores box

        StreamReader reader = new StreamReader(path);
        while (!reader.EndOfStream && scores_read < num_scores)
        {
            line = reader.ReadLine();
            fields = line.Split(',');
            HighScores.text += fields[0] + " : " + fields[1] + "\n";
            scores_read += 1;
        }

    } */

    /*public Transform contentWindow;
    public GameObject recallTextObject;

    void Start ()
    {
        string readFromFilePath = Application.streamingAssetsPath + "/Recall_Chat/" + "scores" + ".txt" + "\n";

        List<string> fileLines = File.ReadAllLines(readFromFilePath).ToList();

        foreach (string line in fileLines)
        {
            Instantiate(recallTextObject, contentWindow);
            recallTextObject.GetComponent<Text>().text = line;
        }
    } */

    [SerializeField] Text txt_allnames;

    string[] namesArray = new string[10];
    string myFilePath, fileName;

    string displayName = NameTransfer.theName;

    int i;

    void Start ()
    {
        fileName = "scores.txt";
        myFilePath = Application.dataPath + "/" + fileName;
        ReadFromTheFile();
    }

    void DisplayAllScores()
    {
        System.Array.Sort(namesArray);
        Array.Reverse(namesArray);
        foreach (string line in namesArray)
        {
            txt_allnames.text += line + "\n";
        }
            
    }

    public void ReadFromTheFile()
    {
            namesArray = File.ReadAllLines(myFilePath);
            DisplayAllScores();     
    }

    /*
    void DisplayOneScore()
    {   
        foreach (string uline in newnamesArray)
        {
            txt_onename.text += uline + "\n";
        }
    }

    public void ReadLastFile()
    {
        var lastLine = File.ReadLines(myFilePath).Last();
        //namesArray = File.ReadAllLines(myFilePath);
        DisplayOneScore();
    }
    */
}
