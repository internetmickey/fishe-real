using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI blueScoreText;
    public TextMeshProUGUI redScoreText;

    private int blueKills = 0;
    private int blueDeaths = 0;
    private int redKills = 0;
    private int redDeaths = 0;

    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BlueKilledRed()
    {
        blueKills++;
        redDeaths++;

        blueScoreText.text = "Blue: " + blueKills.ToString() + " kills, " + redDeaths.ToString() + " deaths";
        redScoreText.text = "Red: " + redKills.ToString() + " kills, " + blueDeaths.ToString() + " deaths";
    }

    public void RedKilledBlue()
    {
        redKills++;
        blueDeaths++;

        blueScoreText.text = "Blue: " + blueKills.ToString() + " kills, " + redDeaths.ToString() + " deaths";
        redScoreText.text = "Red: " + redKills.ToString() + " kills, " + blueDeaths.ToString() + " deaths";
    }

}
