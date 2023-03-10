using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.IO;
using UnityEditor;
using UnityEngine.SceneManagement;

public class frog : MonoBehaviour
{
    public Rigidbody2D rb;

    public AudioSource audioPlayer;

    void Start()
    {
        
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
            rb.MovePosition(rb.position + Vector2.right);
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
            rb.MovePosition(rb.position + Vector2.left);
        else if (Input.GetKeyDown(KeyCode.UpArrow))
            rb.MovePosition(rb.position + Vector2.up);
        else if (Input.GetKeyDown(KeyCode.DownArrow))
            rb.MovePosition(rb.position + Vector2.down);
    }

    public Text writeScore;
    private int newScore = Score.CurrentScore;
    

    public void WriteDaScore()
    {
        string path = "Assets/scores.txt";

        writeScore.text = newScore.ToString();

        //get score
        string scoreToBeWritten = writeScore.text;

        StreamWriter writer = new StreamWriter(path, true);

        writer.WriteLine(scoreToBeWritten);
        writer.Close();

        AssetDatabase.ImportAsset(path);
        TextAsset asset = (TextAsset)Resources.Load("scores");

        Debug.Log("Done writing");
    }
        

    void OnTriggerEnter2D (Collider2D col)
    {
        if (col.tag == "Car")
        {
            audioPlayer.Play();
            Debug.Log("WE LOST!");
            WriteDaScore();
            Score.CurrentScore = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
