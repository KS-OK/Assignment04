using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.IO;
using UnityEditor;

public class WriteScores : MonoBehaviour
{
    /*
    //public InputField NewScore;
    public int NewScore = Score.CurrentScore;
    //public InputField NewName;
    public string NewName = NameTransfer.theName;
    public int num_scores = 10;
    //Score.CurrentScore

    public void AddNewScore()
    {
        string path = "Assets/scores.txt";
        string line;
        string[] fields;
        int scores_written = 0;
        string newName;
        string newScore;
        bool newScoreWritten = false;
        string[] writeNames = new string[10];
        string[] writeScores = new string[10];

        //newName = NewName.text;
        newName = NewName = NameTransfer.theName;
        //newScore = NewScore.text;
        newScore = NewScore.ToString();

        StreamReader reader = new StreamReader(path);
        while (!reader.EndOfStream)
        {
            line = reader.ReadLine();
            fields = line.Split(',');
            if (!newScoreWritten && scores_written < num_scores) // if new score has not been written yet
            {
                //check if we need to write new higher score first
                if (Convert.ToInt32(newScore) > Convert.ToInt32(fields[1]))
                {
                    writeNames[scores_written] = newName;
                    writeScores[scores_written] = newScore;
                    newScoreWritten = true;
                    scores_written += 1;
                }

            }
            if (scores_written < num_scores) // we have not written enough lines yet
            {
                writeNames[scores_written] = fields[0];
                writeScores[scores_written] = fields[1];
                scores_written += 1;
            }
        }
        reader.Close();

        // now we have parallel arrays with names and scores to write
        StreamWriter writer = new StreamWriter(path);

        for (int x = 0; x < scores_written; x++)
        {
            writer.WriteLine(writeNames[x] + " - " + writeScores[x]);
        }
        writer.Close();

        AssetDatabase.ImportAsset(path);
        TextAsset asset = (TextAsset)Resources.Load("scores");

    }
    */
    /**************************************************/
    /* public InputField writeToFile;

    public void WriteString()
    {
        string path = "Assets/scores.txt";

        //get text from the input field
        string dataToBeWritten = writeToFile.text;

        StreamWriter writer = new StreamWriter(path, true);

        writer.WriteLine("\n" + " - " + dataToBeWritten);
        writer.Close();

        AssetDatabase.ImportAsset(path);
        TextAsset asset = (TextAsset)Resources.Load("scores");

        Debug.Log("Done writing");
    }
    */
}