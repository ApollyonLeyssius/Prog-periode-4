using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scoremanager : MonoBehaviour
{
    public int score = 0; // Zorg voor een logische startscore moet deze aanpasbaar zijn in de inspector?

    // Zorg dat de methode AddScore vanaf een ander script ook punten kan doorgeven als argument
    public void AddScore(int points)
    {
        //Tel de meegegeven punten op bij de score
        score += points;
        // Debug de score naar de console
        Debug.Log("Score bijgewerkt: " + points);
    }
}