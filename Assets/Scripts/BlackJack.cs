using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;
using UnityEngine.SceneManagement;

public class BlackJack : MonoBehaviour
{
    
    public TMP_Text playerText;
    public TMP_Text dealerText;
    public TMP_Text winLoseText;
    
    private int _score = 0;
    private int _dealerScore;

    private void Start()
    {
        DealerDrawCard();
    }

    public void DealerDrawCard()
    {
        _dealerScore = Random.Range(17, 27);
    }
    
    public void DrawCard()
    {
        int drawnCard = Random.Range(1, 11);

        _score = _score + drawnCard;
        
        playerText.text = "Player: " + (_score).ToString();
    }

    public void CompareValues()
    {
        dealerText.text = "Dealer: " + _dealerScore;

        if (_score > 21)
        {
            Debug.Log("It's time to die :)");
            Lose();
        }
        else if (_score == 21)
        {
            Debug.Log("Geld zurueck garantie");
            Win();
        }
        else if (_dealerScore > 21)
        {
            Lose();
        }
        else if (_score == _dealerScore)
        {
            Lose();
        }
        else if (_score > _dealerScore)
        {
            Lose();
        }
        else
        {
            Win();
        }
    }

    private void Win()
        {
            winLoseText.text = "Bro du hast gewonnen! das ist krass";
        }
     private void Lose()
        {
            winLoseText.text = "dMKLASJDJMAKLDJASKLD LOL!!!";
        }

     public void Restart()
     {
         SceneManager.LoadScene(1);
     }
    }

