using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class QuizOneCodingChallenge : MonoBehaviour
{
    // Declaring Varaibles
    public int Score = 0;
    public string PlayerName = "Noah";
    public int Health = 100;
    
    // Start is called before the first frame update
    void Start()
    {
        IncreaseScore();
        PrintPlayerName();
        DecreaseHealth();
    }

    // Update is called once per frame
    private void IncreaseScore(int amount)
    {
        Score = Score + amount;
    }
    private void PrintPlayerName()
    {
        Debug.Log(PlayerName);
    }

    private void DecreaseHealth()
    {
        Health = Health - 20;
    }
}
