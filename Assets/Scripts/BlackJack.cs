using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;

public class BlackJack : MonoBehaviour
{
    public TMP_Text playerText;
    public TMP_Text dealerText;
    private int _score = 0;
    private int _dealerScore;

    private void Start()
    {
        DealerDrawCard();
    }

    public void DealerDrawCard()
    {
        _dealerScore = Random.Range(17, 27);

        dealerText.text = "Dealer: " + _dealerScore;
    }
    
    public void DrawCard()
    {
        int drawnCard = Random.Range(1, 11);

        _score = _score + drawnCard;
        
        playerText.text = "Player: " + (_score).ToString();
    }

    public void CompareValues()
    {
        
    }
}
