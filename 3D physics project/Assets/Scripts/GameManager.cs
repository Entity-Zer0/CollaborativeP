using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using TMPro;
using System;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public PlayerMovement myPlayer;
    private int score;

    public TextMeshProUGUI highScoreDisplay;
    public TextMeshProUGUI scoreDisplay;

    public float endTime = 15.0f;

    const string DIR_DATA = "/Data/";
    const string FILE_HIGH_SCORE = "/highScore.Txt/";
    string PATH_HIGH_SCORE;

    public int Score
    {
        get { return score; }
        set
        {
            score = value;
            if (score > highScore)
            {
                highScore = score;
            }
        }
    }

    int highScore;
    public int HighScore
    {
        get { return highScore; }
        set
        {
            highScore = value;
            Directory.CreateDirectory(Application.dataPath + DIR_DATA);
            File.WriteAllText(PATH_HIGH_SCORE, "" + HighScore);
        }
    }
    

    private void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        PATH_HIGH_SCORE = Application.dataPath + DIR_DATA + FILE_HIGH_SCORE;
        //myPlayer = FindObjectOfType<PlayerMovement>();
        highScoreDisplay.enabled = false;

        if (File.Exists(PATH_HIGH_SCORE))
        {
            HighScore = Int32.Parse(File.ReadAllText(PATH_HIGH_SCORE));
        }
    }

    // Update is called once per frame
    void Update()
    {
        scoreDisplay.text = "Score: " + Score;
        highScoreDisplay.text = "High Score: " + HighScore;
        endTime -= Time.deltaTime;
        if(endTime <= 0.0f)
        {
            highScoreDisplay.enabled = true;
        }
        //score = myPlayer.score;
    }
}
