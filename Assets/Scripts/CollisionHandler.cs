using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CollisionHandler : MonoBehaviour
{
    [Tooltip("in Seconds")][SerializeField] float levelLoadDelay = 1f;
    [Tooltip("Particle Effect on Player")][SerializeField] GameObject deathFX;
    void OnTriggerEnter(Collider other)
    {
        StartDeathSequence();
    }

    private void StartDeathSequence()
    {
       
        SendMessage("OnPlayerDeath");
        deathFX.SetActive(true);
        Invoke("ReLoadScene", levelLoadDelay);

    }
    private void ReLoadScene()
    {
        SceneManager.LoadScene(1);
    }
}
