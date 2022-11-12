using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SaveCoinNumber : MonoBehaviour
{
    public TextMeshProUGUI MijnScore;
    private int ScoreNummer;
    // Start is called before the first frame update
    void Start()
    {
        ScoreNummer = 0;
        MijnScore.text = "Coins taken : " + ScoreNummer;
    }
    private void OnTriggerEnter(Collider Coin)
    {
        if (Coin.tag == "coin")
        {
            ScoreNummer++;
            MijnScore.text = "Coins taken : " + ScoreNummer;
        }
    }
}