using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public GameObject startScreen;
    public GameObject endScreen;
    public GameObject playerOne;
    public GameObject playerTwo;
    public GameObject blueScore;
    public GameObject redScore;

    private bool gameOver = false;
    private bool gameStartScreen = true;
    // Start is called before the first frame update
    void Start()
    {
        //Makes Cursor Invisible
        Cursor.visible = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1) && gameStartScreen == true)
        {
            gameStartScreen= false;
            startScreen.gameObject.SetActive(false);
            playerOne.gameObject.SetActive(true);
            playerTwo.gameObject.SetActive(true);
            blueScore.gameObject.SetActive(true);
            redScore.gameObject.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2) && gameOver == true)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        }
        
        //Quits game on ESCAPE
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            // or if (Input.GetButtonUp("Cancel")) {
            Application.Quit();
        }
    }

    public void GameOver()
    {
        gameOver = true;
        //Sets Game Over screen active and turns off other player
        endScreen.gameObject.SetActive(true);
        playerOne.gameObject.SetActive(false);
        playerTwo.gameObject.SetActive(false);
        blueScore.gameObject.SetActive(false);
        redScore.gameObject.SetActive(false);

    }

}
