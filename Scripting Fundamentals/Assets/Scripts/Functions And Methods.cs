using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunctionsAndMethods : MonoBehaviour
{
    // Functions are blocks of code that perform specific tasks and are not associated with any specific object or class. They can be called and executed independently.
    
    // Methods, on the other hand, are functions that are associated with a specific object or class. They can be called and executed on the instances of that object or class.

    //decalre our variables
    private AudioSource _audioSource;
    private float _speed = 10f;
    private int _playerhealthAmount = 100f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Creating some simple functions

    // Function to play a sound effect
    private void PlaySoundAffect(AudioClip soundEffect)
    {
        _audioSource.PlayOneShot(soundEffect);
    }

    //Function to detect Collisions 
    private void OnTriggerEnter(Collider other)
    {
        
    }

    // Creating some simplle methods 

    // Method to move the enemy
    private void MoveEnemy()
    {
        transform.Translate(Vector3.forward * _speed * Time.deltaTime);
    }

    // Mathod to return a value 
    public int Playerhealth(int amount)
    {
        _playerHealthAmount -= amount;

        return _playerHealthAmount;
    }
}
