using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManagerScript : MonoBehaviour
{

    // it is important to assign the GameObjects in the projects GameManager
    public GameObject startCanvas, gameOverCanvas, finishCanvas, instructionsCanvas;
    public TMP_Text scoreText, highscoreText, timerText, finalScoreText, FinishBestScoreText;

    public GameObject player;
    public GameObject coin1, coin2, coin3, coin4, coin5, coin6, coin7, coin8, coin9, coin10, coin11, coin12, coin13, coin14, coin15, coin16, coin17, coin18, coin19, coin20, coin21, coin22;

    // values to calculate the score of the player
    public static float score = 0, highscore = 500, time = 0, finalscore = 0;

    // Start is called before the first frame update
    void Start()
    {
        // initially the player only sees the start canvas of the game
        startCanvas.SetActive(true);
        gameOverCanvas.SetActive(false);
        finishCanvas.SetActive(false);
        instructionsCanvas.SetActive(false);
    }

    public void OnClickedStartButton()
    {
        // when the start button is pressed turn off the start canvas and turn on the instructions canvas
        // which also shows the player their score and time
        startCanvas.SetActive(false);
        gameOverCanvas.SetActive(false);
        finishCanvas.SetActive(false);
        instructionsCanvas.SetActive(true);
        // make sure the player is at the start
        player.transform.position = new Vector3(-10f, 5f, 0f);
        // make sure time starts at zero
        time = 0;
        // if there are Clone coins destroy them (crucial if the play again option is selected)
        ScoreCoinScript.DestroyAllCloneCoins();
        // instantiate the coins at the appropriate positions
        GameObject sc1 = Instantiate(coin1) as GameObject; sc1.transform.position = new Vector3(12f, -3f, 74.63025f);
        GameObject sc2 = Instantiate(coin2) as GameObject; sc2.transform.position = new Vector3(25.5f, -2f, 74.63025f);
        GameObject sc3 = Instantiate(coin3) as GameObject; sc3.transform.position = new Vector3(49f, -3f, 74.63025f);
        GameObject sc4 = Instantiate(coin4) as GameObject; sc4.transform.position = new Vector3(56f, -3f, 74.63025f);
        GameObject sc5 = Instantiate(coin5) as GameObject; sc5.transform.position = new Vector3(76.5f, 0f, 74.63025f);
        GameObject sc6 = Instantiate(coin6) as GameObject; sc6.transform.position = new Vector3(83.5f, 2.5f, 74.63025f);
        GameObject sc7 = Instantiate(coin7) as GameObject; sc7.transform.position = new Vector3(105f, 4f, 74.63025f);
        GameObject sc8 = Instantiate(coin8) as GameObject; sc8.transform.position = new Vector3(107.5f, -2f, 74.63025f);
        GameObject sc9 = Instantiate(coin9) as GameObject; sc9.transform.position = new Vector3(133f, 0f, 74.63025f);
        GameObject sc10 = Instantiate(coin10) as GameObject; sc10.transform.position = new Vector3(149.5f, 2.5f, 74.63025f);
        GameObject sc11 = Instantiate(coin11) as GameObject; sc11.transform.position = new Vector3(163f, -3f, 74.63025f);
        GameObject sc12 = Instantiate(coin12) as GameObject; sc12.transform.position = new Vector3(163f, 1.5f, 74.63025f);
        GameObject sc13 = Instantiate(coin13) as GameObject; sc13.transform.position = new Vector3(174f, -3f, 74.63025f);
        GameObject sc14 = Instantiate(coin14) as GameObject; sc14.transform.position = new Vector3(189f, 1f, 74.63025f);
        GameObject sc15 = Instantiate(coin15) as GameObject; sc15.transform.position = new Vector3(200f, -0.5f, 74.63025f);
        GameObject sc16 = Instantiate(coin16) as GameObject; sc16.transform.position = new Vector3(208f, 0.5f, 74.63025f);
        GameObject sc17 = Instantiate(coin17) as GameObject; sc17.transform.position = new Vector3(222f, -2f, 74.63025f);
        GameObject sc18 = Instantiate(coin18) as GameObject; sc18.transform.position = new Vector3(224f, -2.5f, 74.63025f);
        GameObject sc19 = Instantiate(coin19) as GameObject; sc19.transform.position = new Vector3(226f, -2f, 74.63025f);
        GameObject sc20 = Instantiate(coin20) as GameObject; sc20.transform.position = new Vector3(228f, -2.5f, 74.63025f);
        GameObject sc21 = Instantiate(coin21) as GameObject; sc21.transform.position = new Vector3(230f, -2f, 74.63025f);
        GameObject sc22 = Instantiate(coin22) as GameObject; sc22.transform.position = new Vector3(235f, -1f, 74.63025f);
    }

    public void OnClickedPlayAgainButton()
    {
        // if play again is selected ensure only the instructions canvas is active
        startCanvas.SetActive(false);
        gameOverCanvas.SetActive(false);
        finishCanvas.SetActive(false);
        instructionsCanvas.SetActive(true);
        // place the player at the start
        player.transform.position = new Vector3(-10f, 5f, 0f);
        // set scores and time to zero
        score = 0;
        time = 0;
        finalscore = 0;
        // destroy Clone coins from previous attempt and reposition them
        ScoreCoinScript.DestroyAllCloneCoins();
        GameObject sc1 = Instantiate(coin1) as GameObject; sc1.transform.position = new Vector3(12f, -3f, 74.63025f);
        GameObject sc2 = Instantiate(coin2) as GameObject; sc2.transform.position = new Vector3(25.5f, -2f, 74.63025f);
        GameObject sc3 = Instantiate(coin3) as GameObject; sc3.transform.position = new Vector3(49f, -3f, 74.63025f);
        GameObject sc4 = Instantiate(coin4) as GameObject; sc4.transform.position = new Vector3(56f, -3f, 74.63025f);
        GameObject sc5 = Instantiate(coin5) as GameObject; sc5.transform.position = new Vector3(76.5f, 0f, 74.63025f);
        GameObject sc6 = Instantiate(coin6) as GameObject; sc6.transform.position = new Vector3(83.5f, 2.5f, 74.63025f);
        GameObject sc7 = Instantiate(coin7) as GameObject; sc7.transform.position = new Vector3(105f, 4f, 74.63025f);
        GameObject sc8 = Instantiate(coin8) as GameObject; sc8.transform.position = new Vector3(107.5f, -2f, 74.63025f);
        GameObject sc9 = Instantiate(coin9) as GameObject; sc9.transform.position = new Vector3(133f, 0f, 74.63025f);
        GameObject sc10 = Instantiate(coin10) as GameObject; sc10.transform.position = new Vector3(149.5f, 2.5f, 74.63025f);
        GameObject sc11 = Instantiate(coin11) as GameObject; sc11.transform.position = new Vector3(163f, -3f, 74.63025f);
        GameObject sc12 = Instantiate(coin12) as GameObject; sc12.transform.position = new Vector3(163f, 1.5f, 74.63025f);
        GameObject sc13 = Instantiate(coin13) as GameObject; sc13.transform.position = new Vector3(174f, -3f, 74.63025f);
        GameObject sc14 = Instantiate(coin14) as GameObject; sc14.transform.position = new Vector3(189f, 1f, 74.63025f);
        GameObject sc15 = Instantiate(coin15) as GameObject; sc15.transform.position = new Vector3(200f, -0.5f, 74.63025f);
        GameObject sc16 = Instantiate(coin16) as GameObject; sc16.transform.position = new Vector3(208f, 0.5f, 74.63025f);
        GameObject sc17 = Instantiate(coin17) as GameObject; sc17.transform.position = new Vector3(222f, -2f, 74.63025f);
        GameObject sc18 = Instantiate(coin18) as GameObject; sc18.transform.position = new Vector3(224f, -2.5f, 74.63025f);
        GameObject sc19 = Instantiate(coin19) as GameObject; sc19.transform.position = new Vector3(226f, -2f, 74.63025f);
        GameObject sc20 = Instantiate(coin20) as GameObject; sc20.transform.position = new Vector3(228f, -2.5f, 74.63025f);
        GameObject sc21 = Instantiate(coin21) as GameObject; sc21.transform.position = new Vector3(230f, -2f, 74.63025f);
        GameObject sc22 = Instantiate(coin22) as GameObject; sc22.transform.position = new Vector3(235f, -1f, 74.63025f);
    }

    // Update is called once per frame
    void Update()
    {

        // make the timer and finalscore go up
        time = time + 1 * Time.deltaTime; ;
        finalscore = time - score;

        // when the player goes that low on the y axis they are no longer in the game and Game Over Canvas is activated
        if (player.transform.position.y < -8f)
        {
            gameOverCanvas.SetActive(true);
            instructionsCanvas.SetActive(false);
        }

        // when the player goes that far over on the x axis they have reached the end and Finish Canvas is activated
        if(player.transform.position.x > 234f)
        {
            finishCanvas.SetActive(true);
            instructionsCanvas.SetActive(false);
            // the lower the score the better in this game
            if (finalscore < highscore)
            {
                highscore = finalscore;
                // attatch the Best Score to the TMP for the Finish Canvas
                FinishBestScoreText.text = "Best Score: " + highscore + " seconds!";
            }
        }

        // set up the TMP items for display to the player
        timerText.text = "Time:  " + time + " seconds";
        scoreText.text = "Coins:  " + score;
        finalScoreText.text = "Finalscore:  " + finalscore + " seconds";
        highscoreText.text = "Bestscore:  " + highscore + " seconds";
    }
}
