using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Variables : MonoBehaviour
{
    // Declaring Varaibles
    public int Score = 0;
    public string PlayerName = "Noah";
    PlayerPrefs int _playerhealthAmount = 100f;
    
    // Start is called before the first frame update
    void Start()
    {
            
    }

    // Update is called once per frame
    private void IncreaseScore(int amount)
    {
        // using a local variable tp update the total score
        _Score += amount;
    }
}
