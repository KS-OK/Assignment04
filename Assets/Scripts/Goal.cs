using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.IO;
using UnityEditor;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{

    //public Text writeScore;
    //private int newScore = Score.CurrentScore;
    /*

    public void WriteDaScore()
    {
        string path = "Assets/scores.txt";

        writeScore.text = newScore.ToString();

        //get text from the input field
        string scoreToBeWritten = writeScore.text;

        StreamWriter writer = new StreamWriter(path, true);

        writer.WriteLine("\n" + scoreToBeWritten);
        writer.Close();

        AssetDatabase.ImportAsset(path);
        TextAsset asset = (TextAsset)Resources.Load("scores");

        Debug.Log("Done writing");
    }
        */

    void OnTriggerEnter2D ()
    {
        Debug.Log("YOU WON!");
        Score.CurrentScore += 100;
        //WriteDaScore();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
